using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class control1 : MonoBehaviour
{
    public Rigidbody2D rb;

    public float forwardforce = 1000f;
    public float Upforce = 1000f;
    public float slideforce = 30f;
    Vector2 A = new Vector2(3000.0f, 0.0f);
    Vector2 B = new Vector2(20.0f, 0.0f);
    Vector2 zAngle = new Vector2(1.0f,0.0f);
   
    // Update is called once per frame

    void FixedUpdate()
    {
        
        Vector2 moveDirection = gameObject.GetComponent<Rigidbody2D>().velocity;
        if (moveDirection != Vector2.zero)
        {
            
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle+90, Vector3.forward);
        }

        //rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        
        if (Input.GetKeyDown(KeyCode.D))
        {

            rb.AddForce(A * Time.deltaTime, ForceMode2D.Impulse);
            //rb.AddTorque(2f, ForceMode2D.Impulse);
            //transform.Rotate(0, 0, 5);
        }
        /*if (Input.GetKey("a"))
        {
            rb.AddForce(-slideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }*/
    }

}
