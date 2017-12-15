using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger1 : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreCount.player_1_score == 3)
        {
            SceneManager.LoadScene("Level2");
        }
        else if (scoreCount.player_2_score == 3)
        {
            SceneManager.LoadScene("Level2");
        }

	}
}
