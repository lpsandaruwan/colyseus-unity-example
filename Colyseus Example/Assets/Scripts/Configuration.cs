using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configuration : MonoBehaviour
{
    [SerializeField]
    private InputField hostnameInput = null;

    [SerializeField]
    private InputField portInput = null;

    [SerializeField]
    private InputField gameNameInput = null;

    public string GameName
    {
        get
        {
            return string.IsNullOrEmpty(gameNameInput.text)? "my_name": gameNameInput.text;
        }
    }

    public string HostName
    {
        get
        {
            return string.IsNullOrEmpty(hostnameInput.text)? "localhost": hostnameInput.text;
        }
        
    }
    
    public string Port
    {
        get 
        {
            return string.IsNullOrEmpty(portInput.text)? "2567": portInput.text;
        }
    }
    
    public string Protocol
    {
        get 
        {
            return "ws";
        }
    }
    
    public string GetHostAddress()
    {
        return $"{Protocol}://{HostName}:{Port}";
    }
}