using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class CloseSubmitScore : MonoBehaviour
{
    public TMP_InputField MemberID;
    public Text score;
    public Button submit;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public void close() {
        MemberID.gameObject.SetActive(false);
        score.text = "Score submitted!";
        submit.gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
