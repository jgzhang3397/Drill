using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contact1 : MonoBehaviour
{
    private Animator animator;
    private bool flag = false;
    private int counter = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    //animator.SetBool("conllision", false);
 
    void Update()
    {
        animator.SetBool("conllision", flag);
        Invoke("delayOpen", 5);
        
        // Das dritte Hindernis (welches der Bohrer berührt) beendet das Spiel.
        if (counter>=3)
            {
            SceneManager.LoadScene("menu");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        flag = true;
        counter += 1;
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;
        counter += 1;
    }
    void delayOpen()
    {
        flag = false;
    }
}
