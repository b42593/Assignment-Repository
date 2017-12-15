using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger3 : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreCount.player_1_score == 25)
        {
            SceneManager.LoadScene("WinnerScene");
        }
        else if (scoreCount.player_2_score == 25)
        {
            SceneManager.LoadScene("WinnerScene");
        }

	}
}
