using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public CanvasGroup canvasMainMenu;
    public CanvasGroup canvasAjustes;
    public CanvasGroup canvasCreditos;
    public CanvasGroup canvasPlay;

    private void Start()
    {
        MainMenu(); 
    }

    public void MainMenu()
    {
        EnableCanvasGroup(canvasMainMenu);
    }

    public void AjustesPlaceholder()
    {
        EnableCanvasGroup(canvasAjustes);
    }

    public void CreditosPlaceholder()
    {
        EnableCanvasGroup(canvasCreditos);
    }

    public void PlayPlaceholder()
    {
        EnableCanvasGroup(canvasPlay);
    }

    private void EnableCanvasGroup(CanvasGroup activeCanvas)
    {
        CanvasGroup[] canvasGroups = { canvasMainMenu, canvasAjustes, canvasCreditos, canvasPlay };

        foreach (var canvas in canvasGroups)
        {
            bool isActive = (canvas == activeCanvas);
            canvas.alpha = isActive ? 1 : 0;
            canvas.interactable = isActive;
            canvas.blocksRaycasts = isActive;
        }
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
