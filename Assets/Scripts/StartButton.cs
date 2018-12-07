using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; 

public class StartButton : MonoBehaviour {

    // this will be called by the button component
    // when the button is called
    public void StartGame()

    {
        //reset the score 
        PlayerPrefs.DeleteKey("score");

        //reset the lives 
        PlayerPrefs.DeleteKey("lives");

        // load the first level
        SceneManager.LoadScene("Level 1");

    }
     

}
