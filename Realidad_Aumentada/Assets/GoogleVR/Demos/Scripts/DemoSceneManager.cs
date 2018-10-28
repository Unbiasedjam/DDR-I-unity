namespace GoogleVR.Demos {
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


  // Ensures correct app and scene setup.
  public class DemoSceneManager : MonoBehaviour {

      public Transform player;
      public float playerHeight = 3.6f;
       void Start() {
      Input.backButtonLeavesApp = true;
    }

    void Update() {
      // Exit when (X) is tapped.
      if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
      }
    }

    public void TeleportLocation(Vector3 newPosition){
        player.position = newPosition;
    }

  }
}
