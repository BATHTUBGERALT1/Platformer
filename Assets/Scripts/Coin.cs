using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // variable to let us add to the score 
    // public so we can drag and drop 
    public Score scoreObject;

    // variable to hold the coins point value 
    // public so we can change it in thew editor 
    public int coinValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // unity calls this function when our coin touches any other object 
    // of the player touches us the coin should die and score should rise

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // check if the thing we touched was the player 
        Player playerScript = collision.collider.GetComponent<Player>(); 

        // if the thing we touched HAS a player script that means
        // it IS a player so....
        if(playerScript)
        {

            // we hit the player!

            // add to the score based on our value
            scoreObject.AddScore(coinValue);

            // kill the gameObject that this script is attached to 
            // les COIN 
            Destroy(gameObject);
        }
    }


}
