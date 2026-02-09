using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundctrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("scene").GetComponent<AudioSource>().volume=0;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
