using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleVR.Demos;
public class TeleportZone : MonoBehaviour {

	// Use this for initialization
	DemoSceneManager manager;
	TeleportInteraction timer;

	public void start(){
		manager = FindObjectOfType<DemoSceneManager>();
		timer = GetComponent<TeleportInteraction>();
	}
	public void TeleportPlayer(){
		Vector3 position= new Vector3{

		};
	}

	public void UpdateO(){
		if(timer != null){//logica para el eliminar cosas con el timer u otras acciones
			if(timer.timeUp){
				TeleportPlayer();
				manager.ResetWaitTime();
			}
		}
	}
}
