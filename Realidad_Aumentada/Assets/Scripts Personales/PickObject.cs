using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour {
	// Use this for initialization
	TeleportInteraction timer;
	void Start () {
		timer = GetComponent<TeleportInteraction>();
	}
	
	// Update is called once per frame
	void Update () {
		if(timer != null){
			if(timer.timeUp){
				Destroy(this.gameObject);
			}
		}
	}
}
