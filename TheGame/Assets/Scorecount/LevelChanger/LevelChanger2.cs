using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger2 : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreCount.player_1_score == 10)
        {
            SceneManager.LoadScene("Level3");
        }
        else if (scoreCount.player_2_score == 10)
        {
            SceneManager.LoadScene("Level3");
        }

	}
}
