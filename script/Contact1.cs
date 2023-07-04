using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Contact1 : MonoBehaviour
{
    private Animator animator;
    private bool flag = false;
    private int counter = 0;
    public  Text scoreText;
    public Text depthText;
    public Text progressText;
    public static float distanceTravelled = 0;
    Vector2 lastPosition;
    public Rigidbody2D rb;


    void Start()
    {
        Scoring.totalScore = 0;
        Scoring.remain = 0.0f;
        Scoring.progress = 0;
        distanceTravelled = 0.0f;
        animator = GetComponent<Animator>();
        lastPosition = transform.position;//add
        scoreText.text = "Score: " + Scoring.totalScore;//add
        depthText.text = "Remain: " + Scoring.remain;
        progressText.text = "Progress: " + Scoring.progress + "%";
        
        

    }
    //animator.SetBool("conllision", false);
 
    void Update()
    {
        animator.SetBool("conllision", flag);
        Invoke("delayOpen", 5);
        if (counter>=3)
            {
            SceneManager.LoadScene("menu");
            
        }
        if(Scoring.totalScore == 200) {
            SceneManager.LoadScene("menu");
        }
        distanceTravelled += Mathf.Abs(transform.position.y - lastPosition.y);//add
        lastPosition = transform.position;//add
        Scoring.totalScore = (int)Math.Round(distanceTravelled);//add
        Scoring.remain = 200 - Scoring.totalScore;
        Scoring.progress = Scoring.totalScore / 2;
        
        scoreText.text = "Score: " + Scoring.totalScore;//add
        
        //if (distanceTravelled > BackgroundChange.mantle)
        //{
            depthText.text = "Remain: " + Scoring.remain;
            progressText.text = "Progress: " + Scoring.progress + "%";
       // }

       
    }

    IEnumerator DoRotate() {
    for (int i = 0; i <= 16; ++i) {
        rb.MoveRotation(45 * i);
        yield return new WaitForSeconds(.5f);
        
     }
}
    private void OnCollisionEnter2D(Collision2D other)
    {

        flag = true;
        counter += 1;
        DoRotate();
        Heart.HealthBar();
       
        
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        flag = true;
        counter += 1;
        DoRotate();
        Heart.HealthBar();
        

    }
    void delayOpen()
    {
        flag = false;
    }
}