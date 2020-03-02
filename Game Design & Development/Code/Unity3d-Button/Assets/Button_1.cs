using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_1 : MonoBehaviour {
	Button mybtn;

	// Use this for initialization
	void Start () {
		mybtn = transform.GetComponent<Button>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void mybtnonclick()
	{
		Debug.Log("20173649刘欣伟");
	}
}
