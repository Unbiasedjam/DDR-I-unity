using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleVR.Demos;
public class TeleportZone : MonoBehaviour {

	// Use this for initialization
	DemoSceneManager manager;
	TeleportInteraction timer;

	public void Start(){
		manager = FindObjectOfType<DemoSceneManager>();
		timer = GetComponent<TeleportInteraction>();
		Debug.Log(manager? "start" : "manager null");
	}
	public void TeleportPlayer(){
		Vector3 position= new Vector3(
			transform.position.x,
			transform.position.y + manager.playerHeight,
			transform.position.z
		);
		manager.TeleportLocation(position);
	}

	private void Update(){
		if(timer != null){//logica para el eliminar cosas con el timer u otras acciones
			if(timer.timeUp){
				TeleportPlayer();
			}
		}
	}
}
