using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    // script for exit button
    public void exit()
    {
        Application.Quit();
    }

    // script for play game 
    public void play(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }

    // volume
    public void sounds_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume); 
    }
}
