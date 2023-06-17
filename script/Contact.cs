using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    /*
    When a collision occurs, the method checks if the current game object has the "Bullet" tag. 
    If it does, the game object is destroyed, effectively removing it from the scene. 
    */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (this.gameObject.tag != "Bullet")
            return;
        Destroy(this.gameObject);
    }
    /*private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Bullet")
            return;
        if (other.attachedRigidbody)
            other.attachedRigidbody.AddForce(Vector3.up * 20);
    }*/
}


