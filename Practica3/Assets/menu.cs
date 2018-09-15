using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_princial : MonoBehaviour {
	// Use this for initialization
	public GameObject Panel;

	public GameObject Music;

	public void Start(){
		Panel.SetActive(false);
	}
	public void Update(){

		if(Input.GetKeyDown(KeyCode.I)){
			Panel.SetActive(true);
		}
		if(Input.GetKeyDown(KeyCode.O)){
			Music.SetActive(true);
		}
		
	}
}