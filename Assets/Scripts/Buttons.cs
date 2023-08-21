using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Level");
    }
    public void exit()
    {
        Application.Quit(); 
    }
    public void retry()
    {
        SceneManager.LoadScene("Level");
    }
}
