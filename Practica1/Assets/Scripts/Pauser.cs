﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
			pausePanel.SetActive(paused);
		}

		//if(Input.GetKeyUp(KeyCode.t)){}

		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}

	public void continueGame(){
		Debug.Log("Coninuar");
		paused = false;
		pausePanel.SetActive(paused);
	}

	public void ResetGame(){
		Debug.Log("reset");
		SceneManager.LoadScene(0);
	}

	public void PauseMusic(){
		Debug.Log("mute");
	}
}
