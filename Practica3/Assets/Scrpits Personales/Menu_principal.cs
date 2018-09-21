using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_princial1 : MonoBehaviour {
	// Use this for initialization
	public GameObject infoPanel;

	public GameObject music;

	public void Start(){
		infoPanel.SetActive(false);
		music.SetActive(false);
	}
	public void Update(){

		if(Input.GetKeyDown(KeyCode.I)){
			infoPanel.SetActive(true);
		}
		if(Input.GetKeyDown(KeyCode.O)){
			music.SetActive(true);
		}
		
	}
}
