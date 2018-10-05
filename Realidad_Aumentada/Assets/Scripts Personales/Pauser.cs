using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;
	public GameObject music;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))//cambiar a boton 2
		{
			paused = !paused;
			pausePanel.SetActive(paused);
		}

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

	public void PauseMusic(){
		music.SetActive(false);
	}

	public void PlayMusic(){
		music.SetActive(true);
	}
}
