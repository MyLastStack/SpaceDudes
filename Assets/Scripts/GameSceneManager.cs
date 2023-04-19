using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class GameSceneManager : MonoBehaviour
{
    public static void LoadMainMenu() 
    {
        SceneManager.LoadScene(0); 
    }
    public static void LoadLevelOne() 
    { 
        SceneManager.LoadScene(1); 
    }
    public static void LoadLevelTwo() 
    { 
        SceneManager.LoadScene(2); 
    }
    public static void LoadWinScreen() 
    { 
        SceneManager.LoadScene(3); 
    }
    public static void LoadLoseScreen() 
    { 
        SceneManager.LoadScene(4); 
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
