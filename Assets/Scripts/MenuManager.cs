using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void ExitGame()
    { 
        Application.Quit();
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

}
