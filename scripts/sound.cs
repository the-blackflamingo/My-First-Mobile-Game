using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //GameObject.Find("bgm").GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    
}
