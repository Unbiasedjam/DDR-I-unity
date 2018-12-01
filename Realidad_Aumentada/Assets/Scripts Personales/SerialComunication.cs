using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class SerialComunication : MonoBehaviour {

	SerialPort serial;
	public string port = "COM3";
	public int baudRate = 115200;

	private void Awake(){
		serial = new SerialPort(port, baudRate);
		serial.Open();
		Debug.Log("Serial Port abierto");
	}

	private void Update(){
		if(Input.GetKeyDown(KeyCode.O)){
			Write("LED_ON");
		}
		else if(Input.GetKeyDown(KeyCode.P)){
			Write("LED_OFF");
		}
	}

	public void Write(string command){
		if(serial.IsOpen){
			serial.Write(command);
		}
	}

	public void OnAplicationQuit(){
		serial.Close();
		Debug.Log("Serial Port cerrado");
	}
}
