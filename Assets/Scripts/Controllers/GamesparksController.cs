using UnityEngine;
using System.Collections;
using GameSparks;
using GameSparks.Api;
using GameSparks.Api.Messages;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Core;

// https://docs.gamesparks.com/tutorials/real-time-services/real-time-matchmaking.html

public class GamesparksController : MonoBehaviour {

    private const int itemWidth = 200;
    private const int itemHeight = 30;

    private string matchMakingStatus = "";
    private const string matchMakingStatusSearching = "SEARCHING";
    private const string matchMakingStatusNotFound = "NOT FOUND";
    private const string matchMakingStatusFound = "FOUND";

    void OnGUI()
    {
        GUILayout.BeginHorizontal();

        GUILayout.Label((GS.Available ? "AVAILABLE" : "NOT AVAILABLE"), GUILayout.Width(itemWidth), GUILayout.Height(itemHeight));
        GUILayout.Label((GS.Authenticated ? "AUTHENTICATED" : "NOT AUTHENTICATED"), GUILayout.Width(itemWidth), GUILayout.Height(itemHeight));
        GUILayout.Label("MatchMaking status: " + this.matchMakingStatus, GUILayout.Width(itemWidth), GUILayout.Height(itemHeight));

        GUILayout.EndHorizontal();
    
        if (GUILayout.Button("DeviceAuthenticationRequest", GUILayout.Width(itemWidth), GUILayout.Height(itemHeight)))
        {
            new DeviceAuthenticationRequest()
                .Send((response) =>
                {
                    Debug.Log("DeviceAuthenticationRequest.JSON:" + response.JSONString);
                    Debug.Log("DeviceAuthenticationRequest.HasErrors:" + response.HasErrors);
                    Debug.Log("DeviceAuthenticationRequest.UserId:" + response.UserId);
                });
        }

        if (GUILayout.Button("MatchMakingRequest", GUILayout.Width(itemWidth), GUILayout.Height(itemHeight)))
        {
            matchMakingStatus = matchMakingStatusSearching;

            new MatchmakingRequest()
                .SetMatchGroup("GROUP1")
                .SetMatchShortCode("MPDEMO")
                .SetSkill(0)
                .Send((response) =>
                {
                    Debug.Log(response.HasErrors);
                    Debug.Log(response.Errors);

                    matchMakingStatus = matchMakingStatusNotFound;
                });
        }
    }
}
