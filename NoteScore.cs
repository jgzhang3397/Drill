using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class NoteScore : MonoBehaviour
{
        public Text score;
    // Start is called before the first frame update
    void Start()
    {
    
    score.text = "Score: " + Scoring.totalScore;

    
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
