using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public static int heart = 3;
    public static GameObject game;
  
  
  public static void HealthBar()
    {
       
        if(heart == 3) {
            game = GameObject.FindWithTag("Heart3");
            game.SetActive(false);
            heart = 2;
            return;
        }
        
         if(heart == 2) {
            game = GameObject.FindWithTag("Heart2");
            game.SetActive(false);
            heart = 1;
            return;
            
        }

         if(heart == 1) {
            game = GameObject.FindWithTag("Heart1");
            game.SetActive(false);
            heart = 3;
            return;
        }
       
        
    }
}