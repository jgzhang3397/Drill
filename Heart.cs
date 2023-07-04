using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public static int heart = 3;
    public static GameObject game;
  
  
  // update the health bar by activating or deactivating heart GameObjects based on the value of the 'heart' variable
  public static void HealthBar()
    {
       	// all three hearts are active
        if(heart == 3) {
            game = GameObject.FindWithTag("Heart3");
            game.SetActive(false);
            heart = 2;
            return;
        }
        
        // one heart has been depleted
         if(heart == 2) {
            game = GameObject.FindWithTag("Heart2");
            game.SetActive(false);
            heart = 1;
            return;
            
        }
	 // two hearts have been depleted
         if(heart == 1) {
            game = GameObject.FindWithTag("Heart1");
            game.SetActive(false);
            heart = 3;
            return;
        }
       
        
    }
}
