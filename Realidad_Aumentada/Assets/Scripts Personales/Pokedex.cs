using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokedex : MonoBehaviour {

	public GameObject inventoryPanel;

	public GameObject backgroundPanel;

	public void addNewItem(Sprite sprite){
		GameObject item = new GameObject();
		item.transform.SetParent(inventoryPanel.transform);
		Image image = item.AddComponent<Image>();
		image.sprite = sprite;
	}

	public void Start(){
		backgroundPanel.SetActive(false);
	}

	public void Update(){ //Cambiar la tecla B por el click del boton
		
	}

	public void Panel(){
			backgroundPanel.SetActive(!backgroundPanel.activeSelf);
	}

	public void Exit(){
		Application.quitting += Quit;
	}
	
	public void Quit(){
		Debug.Log("Bye");
	}
    
}
