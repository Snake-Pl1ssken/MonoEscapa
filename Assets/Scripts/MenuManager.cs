using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject canvasMainMenu;
    public GameObject canvasAjustes;
    public GameObject canvasCreditos;

    public void MainMenu()
    {
        canvasMainMenu.SetActive(true);
        canvasAjustes.SetActive(false);
        canvasCreditos.SetActive(false);
    }

    public void AjustesPlaceholder()
    { 
        canvasAjustes.SetActive(true);
        canvasCreditos.SetActive(false);
        canvasMainMenu.SetActive(false);
    }

    public void creditosPlaceholder()
    {
        canvasCreditos.SetActive(true);
        canvasAjustes.SetActive(false);
        canvasMainMenu.SetActive(false);
    }

    public void ExitGame()
    { 
        Application.Quit();
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

}
