using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject canvasMainMenu;
    public GameObject canvasAjustes;
    public GameObject canvasCreditos;
    public GameObject canvasPlay;

    public void MainMenu()
    {
        canvasMainMenu.SetActive(true);
        canvasAjustes.SetActive(false);
        canvasCreditos.SetActive(false);
        canvasPlay.SetActive(false);
    }

    public void AjustesPlaceholder()
    { 
        canvasAjustes.SetActive(true);
        canvasCreditos.SetActive(false);
        canvasMainMenu.SetActive(false);
        canvasPlay.SetActive(false);
    }

    public void creditosPlaceholder()
    {
        canvasCreditos.SetActive(true);
        canvasAjustes.SetActive(false);
        canvasMainMenu.SetActive(false);
        canvasPlay.SetActive(false);
    }
    public void playPlaceholder()
    {
        canvasCreditos.SetActive(false);
        canvasAjustes.SetActive(false);
        canvasMainMenu.SetActive(false);
        canvasPlay.SetActive(true);
    }

    public void ExitGame()
    { 
        Application.Quit();
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void DayNightGame()
    {
        SceneManager.LoadScene("DayNightCycle");
    }
}
