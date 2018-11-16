using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// extra using statemet to allow us to use scene management functions
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour {


    //designer variables 
    public string sceneToLoad;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //check if the thing that we collided with 
        // is the player(has a player script)
        Player playerScript = collision.collider.GetComponent<Player>();   

        // only do something if the thing we ran into 
        // was infact the player
        // akak playerscript is not null
        if (playerScript != null)
        {
            // we DID hit the player !!!!!!

            //next level
            SceneManager.LoadScene(sceneToLoad);
    
        }

    }

}
