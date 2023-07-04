using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    private GameObject gameObjectFoundBySearch;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectFoundBySearch = GameObject.FindGameObjectWithTag("Cam"); //access and track the position of the camera object
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // compare the difference between the y-axis position of the obstacle and the y-axis of the camera 
        // if the difference exceeds 15 units, the obstacle should be destroyed 
        if(transform.position.y - gameObjectFoundBySearch.transform.position.y > 15 ) {
            
            Destroy(this.gameObject);

        }
    }
}
