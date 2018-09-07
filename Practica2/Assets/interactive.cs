using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactive : MonoBehaviour {
	// Use this for initialization
	
	public Color color;
	private bool isPlayerInside = false;
	public GameObject infoPanel;


	public void Start(){
		infoPanel.SetActive(false);
	}
	public void Update(){

		transform.Rotate(Vector3.up * Time.deltaTime );

		if(Input.GetKeyDown(KeyCode.I) && isPlayerInside){
			gameObject.GetComponent<Renderer>().material.color = color;
		}
	}

	public void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			//this.gameObject.GetComponent<Renderer>().material.color = color;
			infoPanel.SetActive(true);
			isPlayerInside = true;
		}
		
	}

	public void OnTriggerExit(Collider other){
		if(other.CompareTag("Player")){
			infoPanel.SetActive(false);
			isPlayerInside = false;
		}
	}
}
