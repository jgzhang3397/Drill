// the required Unity engine libraries 
using UnityEngine.UI;
using LootLocker.Requests;
using UnityEngine;
using TMPro;
using System;

public class LeaderBoardController : MonoBehaviour
{
    public TMP_InputField MemberID, PlayerScore; // the input fields where the player can enter their member ID and player score
    public int ID;
    public int Max = 4;
    public TMP_Text[] rank;
    public TMP_Text[] member_id;
    public TMP_Text[] score;
    bool t = false;
    // Start is called before the first frame update
    private void Start()
    {
        // start a guest session for the leaderboard
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            // check whether the session was successful or not 
            if(response.success)
            {
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed");
            }
        });  
       
    }
    void Update() {
    	// update the leaderboard UI continuously 
        if(t != true) {

        ShowScores();
        t = false;
        }
    }
    public void ShowScores()
    {
        LootLockerSDKManager.GetScoreList(ID,Max,(response) => // pass the leaderboard ID and maximum number of scores to retrieve 
        {
            if(response.success)
            {
            	// if success, updates the rank, member ID, and scores
                 LootLockerLeaderboardMember[] scores = response.items;
                for(int n = 0; n < scores.Length; n++)  
                {
                    //Entries[n].text = (scores[n].rank + " " + scores[n].member_id + ".   " + scores[n].score); 
                    rank[n].text = scores[n].rank + "";
                    member_id[n].text = scores[n].member_id + "";
                    score[n].text = scores[n].score + "";


                } 
                // if the number of retrieved scores is less than the maximum
                // it fills the remaining UI elements with placeholder values 
                if(scores.Length < Max) 
                {
                    for(int i = scores.Length; i < Max; i++) {
                       // Entries[i].text = (i+1).ToString() + ".   none";
                    }
                }
                t = true;
            }
            else {
                
                Debug.Log("Failed2");
            }
        });
    }
    // retrieves the player's ID and score t=from the UI input fields 
    public void SubmitScore()
    {
        int t = Convert.ToInt32(Contact1.distanceTravelled);
       
        LootLockerSDKManager.SubmitScore(MemberID.text, t, ID, (response) => //PlayerScore.text ändern.
         {
            if(response.success)
            {
                Debug.Log("Success");
                ShowScores();
            }
            else
            {
                Debug.Log("Failed1");
            }
        });  

    }
}
