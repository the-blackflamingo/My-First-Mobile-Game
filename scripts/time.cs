using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text timerr;
    public GameObject win;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        timerr.text = timer.ToString();
        timer -= 1 * Time.deltaTime;
        if (timer < 0)
        {
            Time.timeScale = 0;
            win.SetActive(true);
        }
    }
}
