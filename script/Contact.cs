using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{

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


