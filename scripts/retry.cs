using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    
   
    public void tryAgain()
    {
        
        SceneManager.LoadScene("Scene1");
        Time.timeScale = 1;
    }
    public void exit()
    {
        Application.Quit();
    }
}
