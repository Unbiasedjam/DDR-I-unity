using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour {

	public Sprite sprite;
	

	public void OnCollisionEnter(Collision collision){
		//collision.gameObject.name == "Sphere";
		FindObjectOfType<Pokedex>().addNewItem(sprite);
		Destroy(this.gameObject);
		
	}
}
