using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Created by : Samridhi on Jan 27,2024.
/// Result: Switch scenes on button click.
/// </summary>
public class SwitchScenes : MonoBehaviour
{
    //Load the next scene on Click event.   
    public void TaskOnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    //Exit the application.
    public void CloseApp()
    {
        Application.Quit();
    }
}
