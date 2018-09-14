using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GamePlay_Pause : MonoBehaviour {

	public Material playbuttonMaterial;
	public Material pauseButtonMaterial;
	public Renderer ScreenRenderer;
	private VideoPlayer videoplayer;

	void Awake(){
		videoplayer = GetComponent<VideoPlayer>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Playpause(){
		if(videoplayer.isPlaying){
			videoplayer.Pause();
			ScreenRenderer.material = playbuttonMaterial;
		}
		else{
			videoplayer.Play();
			ScreenRenderer.material = pauseButtonMaterial;
		}
	}
}
