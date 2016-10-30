using UnityEngine;
using System.Collections;
using GameSparks;
using GameSparks.Api;
using GameSparks.Api.Messages;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Core;
using UnityEngine.UI;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class LobbyManager : MonoBehaviour {

    public Button matchMakingButton;

    public Button startGameButton;

    private RTSessionInfo tempRTSessionInfo;

    void Start()
    {
        GS.GameSparksAvailable += (isAvailable) => {
            if (isAvailable)
            {
                Debug.Log("GameSparks Connected...");

                GameSparksManager.Instance().AuthenticateUser(OnAuthentication);
            }
            else
            {
                Debug.Log("GameSparks Disconnected...");
            }
        };

        matchMakingButton.onClick.AddListener(() => {
            GameSparksManager.Instance().FindPlayers();
        });

        GameSparks.Api.Messages.MatchNotFoundMessage.Listener = (message) => {
            Debug.Log("Match not found...");
        };

        GameSparks.Api.Messages.MatchFoundMessage.Listener += this.OnMatchFound;

        startGameButton.onClick.AddListener(() => {
            GameSparksManager.Instance().StartNewRTSession(tempRTSessionInfo);
        });
    }

    /// <summary>
    /// This is called when a player is authenticated
    /// </summary>
    /// <param name="response">Resp.</param>
    private void OnAuthentication(AuthenticationResponse response)
    {
        Debug.Log("User ID: " + response.UserId);
        Debug.Log("User Authenticated...");
    }

    /// <summary>
    /// This is called when a match is found
    /// </summary>
    /// <param name="response">Resp.</param>
    private void OnMatchFound(GameSparks.Api.Messages.MatchFoundMessage response)
    {
        tempRTSessionInfo = new RTSessionInfo(response); // we'll store the match data until we need to create an RT session instance
        matchMakingButton.gameObject.SetActive(false);
        startGameButton.gameObject.SetActive(true);

        Debug.Log("Match Found!...");
        StringBuilder sBuilder = new StringBuilder();
        sBuilder.AppendLine("Match Found...");
        sBuilder.AppendLine("Host URL:" + response.Host);
        sBuilder.AppendLine("Port:" + response.Port);
        sBuilder.AppendLine("Access Token:" + response.AccessToken);
        sBuilder.AppendLine("MatchId:" + response.MatchId);
        sBuilder.AppendLine("Opponents:" + response.Participants.Count());
        sBuilder.AppendLine("_________________");
        sBuilder.AppendLine();
        foreach (GameSparks.Api.Messages.MatchFoundMessage._Participant player in response.Participants)
        {
            sBuilder.AppendLine("Player:" + player.PeerId + " User Name:" + player.DisplayName); // add the player number and the display name to the list
        }
        Debug.Log(sBuilder.ToString());
    }

    public class RTSessionInfo
    {
        private string hostURL;
        public string GetHostURL() { return this.hostURL; }
        private string acccessToken;
        public string GetAccessToken() { return this.acccessToken; }
        private int portID;
        public int GetPortID() { return this.portID; }
        private string matchID;
        public string GetMatchID() { return this.matchID; }

        private List<RTPlayer> playerList = new List<RTPlayer>();
        public List<RTPlayer> GetPlayerList()
        {
            return playerList;
        }

        /// <summary>
        /// Creates a new RTSession object which is held until a new RT session is created
        /// </summary>
        /// <param name="_message">Message.</param>
        public RTSessionInfo(MatchFoundMessage _message)
        {
            portID = (int)_message.Port;
            hostURL = _message.Host;
            acccessToken = _message.AccessToken;
            matchID = _message.MatchId;
            // we loop through each participant and get their peerId and display name //
            foreach (MatchFoundMessage._Participant p in _message.Participants)
            {
                playerList.Add(new RTPlayer(p.DisplayName, p.Id, (int)p.PeerId));
            }
        }

        public class RTPlayer
        {
            public RTPlayer(string _displayName, string _id, int _peerId)
            {
                this.displayName = _displayName;
                this.id = _id;
                this.peerId = _peerId;
            }

            public string displayName;
            public string id;
            public int peerId;
            public bool isOnline;
        }
    }
}
