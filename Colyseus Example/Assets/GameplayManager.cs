using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
