using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactive : MonoBehaviour {
	// Use this for initialization
	
	private bool isPlayerInside = false;
	public GameObject infoPanel;

	public GameObject Canvas;

	public bool rotateObject = false;

	public float rotationSpeed = 45;

	public void Start(){
		infoPanel.SetActive(true);
	}
	public void Update(){

		if(rotateObject == true){
		transform.Rotate(Vector3.up * Time.deltaTime);
			}
		else{
			Canvas.transform.RotateAround(transform.position, Vector3.up, rotationSpeed*Time.deltaTime);
		} 

		if(Input.GetKeyDown(KeyCode.O) && isPlayerInside){
			//gameObject.GetComponent<Renderer>().material.color = color;
			rotationSpeed = 100;
			rotateObject = true;
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
			isPlayerInside = false;
			infoPanel.SetActive(true);
			rotateObject = false;
		}
	}

}
