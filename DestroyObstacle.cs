using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    private GameObject gameObjectFoundBySearch;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectFoundBySearch = GameObject.FindGameObjectWithTag("Cam");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if(transform.position.y - gameObjectFoundBySearch.transform.position.y > 15 ) {
            
            Destroy(this.gameObject);

        }
    }
}
