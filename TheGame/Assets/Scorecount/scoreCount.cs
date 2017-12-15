using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreCount : MonoBehaviour {

    public static int player_1_score = 0;
    public static int player_2_score = 0;

    public static bool canAddScore = true;

    public Text Scoreboard;
    public GameObject ball;

    // Use this for initialization
    void Start () {
        ball = GameObject.Find("Ball");
    }
	
	// Update is called once per frame
	void Update () {

        if (ball.transform.position.x >= 18f)
        {
            canAddScore = false;
            player_1_score++;
            
        }

        if (ball.transform.position.x <= -18f)
        {
            canAddScore = false;
            player_2_score++;
            
        }

        Scoreboard.text = "Score: " + player_1_score.ToString() + " - " + player_2_score.ToString();
        Debug.Log(player_1_score + " , " + player_2_score);
	}

    
}
