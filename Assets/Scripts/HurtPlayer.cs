using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    //unity calls this function automatically
    // whenever the hurtful things touch any other object 
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

            //Kill themmmmm
            playerScript.Kill();

        }

    }


}
