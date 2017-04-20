using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame()
    {
        Application.LoadLevel("firstball01");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
