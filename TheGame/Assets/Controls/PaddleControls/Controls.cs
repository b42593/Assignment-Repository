using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    public GameObject leftpaddle;
    public GameObject rightpaddle;

    // Use this for initialization
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        //leftpaddle
        //make it stop moving if no button is being pressed
        leftpaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        //player 1 presses w leftpaddle goes up 
        if (Input.GetKey(KeyCode.W))
        {
            leftpaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 13f);
            Debug.Log("Player 1 pressed W");
        }
        //player 1 presses s leftpaddle goes down 
        else if (Input.GetKey(KeyCode.S))
        {
            leftpaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -13f);
            Debug.Log("Player 1 pressed S");
        }

        //rightpaddle
        //make it stop moving if no button is being pressed
        rightpaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        //player 1 presses UpArrow leftpaddle goes up 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightpaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 13f);
            Debug.Log("Player 2 pressed UpArrow");
        }
        //player 1 presses DownArrow leftpaddle goes down 
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rightpaddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -13f);
            Debug.Log("Player 2 pressed DownArrow");
        }

    }
}