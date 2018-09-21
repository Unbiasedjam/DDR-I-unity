using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour {

	public GameObject inventoryPanel;

	public GameObject backgroundPanel;

	public Sprite SwordSprite; //lista de items
	

	public void addNewItem(){
		GameObject item = new GameObject();
		item.transform.SetParent(inventoryPanel.transform);
		Image image = item.AddComponent<Image>();
		image.sprite = SwordSprite;
	}

	public void Start(){
		backgroundPanel.SetActive(false);
	}

	public void Update(){
		if(Input.GetKey(KeyCode.B)){
			backgroundPanel.SetActive(!backgroundPanel.activeSelf);
		}
	}
}
