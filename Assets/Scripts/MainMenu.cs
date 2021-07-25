using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    

    void Start()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameSong2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void MainMenuB()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void BackShop()
    {
        SceneManager.LoadScene("GameOver");
    }
}
