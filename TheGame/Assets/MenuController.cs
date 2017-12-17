using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


    public Button play;
    public Button Quit;

    // Use this for initialization
    void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Play_Game()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Quit_Game()
    {
        // If app is built
        Application.Quit();
        Debug.Log("Game Exiting");

        // in editor exit
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Game Exiting");
    }
}
