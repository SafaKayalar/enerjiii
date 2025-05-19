using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private void Start()
    {
      
    }
    public void oyna() 
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    } 
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
