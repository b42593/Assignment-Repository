using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winnerScript : MonoBehaviour {   

    public Text WinnerAnnouncement;
    

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if (scoreCount.player_1_score > scoreCount.player_2_score)
        {

            WinnerAnnouncement.text = "Winner is:: Player 1 won with " + scoreCount.player_1_score.ToString();
        }

        else
        {
            WinnerAnnouncement.text = "Winner is: Player 2 won with " + scoreCount.player_2_score.ToString();
        }

        
	}

    
}
