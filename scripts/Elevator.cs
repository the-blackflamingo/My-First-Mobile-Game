using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject elevator;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 2.5)
        {
            timer = 0;
            elev();
        }
    }

    private void elev()
    {
        GameObject ele = Instantiate(elevator, new Vector3(0, -5.50f, 0), Quaternion.identity);
        //Destroy(ele, 4f);
    }
}
