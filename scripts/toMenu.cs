using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void menu() {
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }
    }
}
