using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeballThrower : MonoBehaviour {

	public GameObject pokeballPrefab;
	public float throwSpeed = 20f;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			transform.LookAt(Vector3.zero);//mire hacia el centro
			GameObject pokeball = (GameObject) Instantiate(pokeballPrefab, transform.position, transform.rotation);//instanciar la pokebola
			pokeball.GetComponent<Rigidbody>().AddForce(transform.forward * throwSpeed, ForceMode.Impulse);//fuerza hacia enfrente
		}
	}
}

///On mouseDown