using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuScreen; // Reference to the main menu screen GameObject
    public GameObject optionsScreen; // Reference to the options screen GameObject
    public GameObject creditsScreen; // Reference to the credits screen GameObject

    private void Start()
    {
        ShowMainMenuScreen(); // Show the main menu screen when the game starts
    }

    public void ShowMainMenuScreen()
    {
        mainMenuScreen.SetActive(true);
        optionsScreen.SetActive(false);
        creditsScreen.SetActive(false);
    }

    public void ShowOptionsScreen()
    {
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(true);
        creditsScreen.SetActive(false);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace "GameScene" with the name of your actual game scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}





