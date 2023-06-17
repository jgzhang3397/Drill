using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class control1 : MonoBehaviour
{

    //public Rigidbody2D rb;
    //public float forwardforce = 1000f;
    //public float Upforce = 1000f;
    //public float slideforce = 30f;
    
    Vector2 A = new Vector2(3000.0f, 0.0f); // x = 3000
    //Vector2 B = new Vector2(20.0f, 0.0f);
    //Vector2 zAngle = new Vector2(1.0f,0.0f);
   
    // Update is called once per fram
    void FixedUpdate()
    {
    
        Vector2 moveDirection = gameObject.GetComponent<Rigidbody2D>().velocity;

        // check if the object is currently moving, if its velocity is non-zero
        if (moveDirection != Vector2.zero)
        {
            // Rotate the object based on the velocity direction
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle+90, Vector3.forward);
        }

        // check if the 'D' key has been pressed 
        if (Input.GetKeyDown(KeyCode.D))
        {
            // apply a force to the object to change it direction to right 
            rb.AddForce(A * Time.deltaTime, ForceMode2D.Impulse);
        }
        
    }

}
