using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using statement for the unity UI code
using UnityEngine.UI; 

public class Score : MonoBehaviour {



    //variable to track the visible text score
    //  Public to let us drag and drop in the editor 
    public Text scoreText;

    //variable to track the numerical score 
    // private because other scripts should not change it directly
    // default to 0 since we should not have any score when starting 

    private int numericalScore = 0; 

	// Use this for initialization
	void Start () {
        // get the score from the prefs database 
        // use a default of 0 of no score was save
        // store the result in our numerical score variable 
        numericalScore = PlayerPrefs.GetInt("score", 0);

        // update the visual score 
        scoreText.text = numericalScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // function to increase the score 
    //      public  so other scripts can use it (such as the coin)
    public void AddScore(int _toAdd)
    {
        // add the amount to the numerical score 
        numericalScore = numericalScore + _toAdd;

        // update the visual score
        scoreText.text = numericalScore.ToString(); 
    }

    // function to save the score to the player preferences 
    //  public so it can be triggered from another script(door)
    public void SaveScore()
    {

        PlayerPrefs.SetInt("score", numericalScore); 

    }
}
