using System;
using System.Collections;
using System.Collections.Generic;
using Colyseus;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    private static ColyseusClient _client = null;
    private static MenuManager _menuManager = null;
    
    public ColyseusClient Client
    {
        get
        {
            if (_client == null)
            {
                _menuManager = gameObject.AddComponent<MenuManager>();
                _client = new ColyseusClient(_menuManager.HostAddress);
                Debug.Log(_client.Endpoint);
            }

            return _client;
        }
    }

    public void JoinGame()
    {
        Client.JoinOrCreate(_menuManager.GameName);
    }
}
