using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;	
	public GameObject panelPrincipal;
	public void pausa(){
		panelPrincipal.SetActive(paused);
		paused = !paused;
		pausePanel.SetActive(paused);
		
		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}

	public void continueGame(){
		paused = false;
		pausePanel.SetActive(paused);
	}

	public void QuitGame(){
		Application.Quit();
	}

}
