using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ele_up : MonoBehaviour
{
    public GameObject Lose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "elevator")
        {
            Destroy(other.gameObject);

        }
        if (other.name=="Jason")
        {
            Destroy(other.gameObject);
            GameObject.Find("death").GetComponent<AudioSource>().Play();
            Lose.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
