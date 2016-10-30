using UnityEngine;
using System.Collections;
using GameSparks;
using GameSparks.Api;
using GameSparks.Api.Messages;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Core;
using System;
using GameSparks.RT;
using UnityEngine.SceneManagement;

public class GameSparksManager : MonoBehaviour {

    private GameSparksRTUnity gameSparksRTUnity;

    public GameSparksRTUnity GetRTSession()
    {
        return gameSparksRTUnity;
    }

    private LobbyManager.RTSessionInfo sessionInfo;

    public LobbyManager.RTSessionInfo GetSessionInfo()
    {
        return sessionInfo;
    }

    /// <summary>The GameSparks Manager singleton</summary>
    private static GameSparksManager instance = null;

    /// <summary>This method will return the current instance of this class </summary>
    public static GameSparksManager Instance()
    {
        if (instance != null)
        {
            return instance; // return the singleton if the instance has been setup
        }
        else
        {
            Debug.LogError("GSM| GameSparksManager Not Initialized...");
        }

        return null;
    }

    void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    public delegate void AuthCallback(AuthenticationResponse _authresp);

    /// <summary>
    /// Sends an authentication request or registration request to GS.
    /// </summary>
    /// <param name="_callback1">Auth-Response</param>
    /// <param name="_callback2">Registration-Response</param>
    public void AuthenticateUser(AuthCallback _authcallback)
    {
        new DeviceAuthenticationRequest()
                .Send((response) =>
                {
                    Debug.Log("DeviceAuthenticationRequest.JSON:" + response.JSONString);
                    Debug.Log("DeviceAuthenticationRequest.HasErrors:" + response.HasErrors);
                    Debug.Log("DeviceAuthenticationRequest.UserId:" + response.UserId);

                    if(!response.HasErrors)
                    {
                        _authcallback(response);
                    }
                });
    }

    /// <summary>
    /// This will request a match between as many players you have set in the match.
    /// When the max number of players is found each player will receive the MatchFound message
    /// </summary>
    public void FindPlayers()
    {
        Debug.Log("GSM| Attempting Matchmaking...");

        new MatchmakingRequest()
            .SetMatchShortCode("MPDEMO")
            .SetSkill(0)
            .Send((response) => {
                if (response.HasErrors)
                {
                    Debug.LogError("GSM| MatchMaking Error \n" + response.Errors.JSON);
                }
            });
    }

    public void StartNewRTSession(LobbyManager.RTSessionInfo tempRTSessionInfo)
    {
        Debug.Log("GSM| Creating New RT Session Instance...");
        sessionInfo = tempRTSessionInfo;
        gameSparksRTUnity = this.gameObject.AddComponent<GameSparksRTUnity>(); // Adds the RT script to the game
                                                                               // In order to create a new RT game we need a 'FindMatchResponse' //
                                                                               // This would usually come from the server directly after a successful MatchmakingRequest //
                                                                               // However, in our case, we want the game to be created only when the first player decides using a button //
                                                                               // therefore, the details from the response is passed in from the gameInfo and a mock-up of a FindMatchResponse //
                                                                               // is passed in. //
        GSRequestData mockedResponse = new GSRequestData()
                                            .AddNumber("port", (double)tempRTSessionInfo.GetPortID())
                                            .AddString("host", tempRTSessionInfo.GetHostURL())
                                            .AddString("accessToken", tempRTSessionInfo.GetAccessToken()); // construct a dataset from the game-details

        FindMatchResponse response = new FindMatchResponse(mockedResponse); // create a match-response from that data and pass it into the game-config
        // So in the game-config method we pass in the response which gives the instance its connection settings //
        // In this example, I use a lambda expression to pass in actions for 
        // OnPlayerConnect, OnPlayerDisconnect, OnReady and OnPacket actions //
        // These methods are self-explanatory, but the important one is the OnPacket Method //
        // this gets called when a packet is received //

        gameSparksRTUnity.Configure(response,
            (peerId) => { OnPlayerConnectedToGame(peerId); },
            (peerId) => { OnPlayerDisconnected(peerId); },
            (ready) => { OnRTReady(ready); },
            (packet) => { OnPacketReceived(packet); });
        gameSparksRTUnity.Connect(); // when the config is set, connect the game
    }

    private void OnPlayerConnectedToGame(int _peerId)
    {
        Debug.Log("GSM| Player Connected, " + _peerId);
    }

    private void OnPlayerDisconnected(int _peerId)
    {
        Debug.Log("GSM| Player Disconnected, " + _peerId);
    }

    private void OnRTReady(bool _isReady)
    {
        if (_isReady)
        {
            Debug.Log("GSM| RT Session Connected...");

            SceneManager.LoadScene("GameScene");
        }
    }

    private void OnPacketReceived(RTPacket _packet)
    {
    }
}
