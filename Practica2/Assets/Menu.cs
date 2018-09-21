using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	// Use this for initialization
	public GameObject Panel;

	public void Start(){
		Panel.SetActive(false);
	}
	public void Update(){

		if(Input.GetKeyDown(KeyCode.I)){
			Panel.SetActive(true);
		}
	}
}
