using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerLevel3 : MonoBehaviour {
    private Rigidbody2D rb;

    public GameObject paddle1;
    public GameObject paddle2;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

        paddle1 = GameObject.Find("Paddle_1");
        paddle2 = GameObject.Find("Paddle_2");


        StartCoroutine(Pause());
    }
	
	// Update is called once per frame
	void Update () {
        //ball teleporting out of map and counting score from scoreCount
        if(this.transform.position.x >= 18f)
        {

            scoreCount.canAddScore = true;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }

        if (this.transform.position.x <= -18f)
        {
            scoreCount.canAddScore = true;
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        } 
    }
    // To Pause the ball after player1/2 scores and at the beginning.
    IEnumerator Pause()
    {
        //ball goes random direction
        int xAxis = Random.Range(-1, 2);
        int yAxis = Random.Range(-1, 2);

        if (xAxis == 0)
        {
            xAxis = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector2(15f * xAxis, 15f * yAxis);
    }

    /*when ball hits paddle, if paddle is moving the ball
    goes the direction in which the paddle is moving.
    If the paddle is not moving the ball goes straight at higher speed.*/

    private void OnCollisionEnter2D(Collision2D paddleHit)
    {
        if (paddleHit.gameObject.name == "Paddle_1")
        {
            if (paddle1.GetComponent<Rigidbody2D> ().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(15f, 15f);
            }
            else if (paddle1.GetComponent<Rigidbody2D> ().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(15f, -15f);
            }
            else
            {
                rb.velocity = new Vector2(25f, 0f);
            }
        }
        if (paddleHit.gameObject.name == "Paddle_2")
        {
            if (paddle2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-20f, 20f);
            }
            else if (paddle2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-20f, -20f);
            }
            else
            {
                rb.velocity = new Vector2(-25f, 0f);
            }
        }
    }
}
