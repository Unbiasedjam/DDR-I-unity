using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleVR.Demos;

public class TeleportInteraction : MonoBehaviour {

	// Use this for initialization

	[Range(1f,3f)]
	public float gazeTime = 3f;
	public float elpasedTime = 0f;
	public bool isCounting = false;
    [HideInInspector]
    public bool timeUp = false;

	void Start(){
	}
    private void Update(){
		if(isCounting){
			elpasedTime += Time.deltaTime;
			if(elpasedTime >= gazeTime){
				timeUp = true;
			}
		}
	}

	public void StarTime(){
		elpasedTime = 0f;
		isCounting = true;
		timeUp = false;
	}

	public void StopTimer(){
		isCounting = false;
		elpasedTime = 0f;
		timeUp = false;
	}
}
