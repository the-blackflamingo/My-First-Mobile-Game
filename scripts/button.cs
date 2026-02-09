using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public bool isWalkingL = false;
    public bool isWalkingR = false;
    public Rigidbody2D rb;
    public int jump = 3500;
    public int speed = 150;

    private void FixedUpdate()
    {
        if (isWalkingL)
        {
        rb.AddForce(Vector2.left * speed);
        }
        if (isWalkingR)
        {
            rb.AddForce(Vector2.right * speed);
        }
    }
    public void isTriggerL( bool CanMoveL)
    {
        isWalkingL = CanMoveL;
    }
    public void isTriggerR(bool CanMoveR)
    {
        isWalkingR = CanMoveR;
    }

    public void spring()
    {
        rb.AddForce(Vector2.up * jump);
    }
  
}
    


