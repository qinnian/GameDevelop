using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_3 : MonoBehaviour {
	Image myImg;
	private float Speed=0.3f;

	// Use this for initialization
	void Start () {
		myImg = transform.GetComponent<Image>();
		myImg.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	myImg.fillAmount += Time.deltaTime * Speed;
		
	}
}
