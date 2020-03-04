using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tog01 : MonoBehaviour {

	Toggle mytog;

	// Use this for initialization
	void Start () {

		mytog = transform.GetComponent<Toggle> ();
		mytog.onValueChanged.AddListener (ToggleSelected);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ToggleSelected(bool Sel){

		if (Sel) {

			Debug.Log (transform.GetComponentInChildren<Text>().text + "is selected!");

		}

	}
			
}
