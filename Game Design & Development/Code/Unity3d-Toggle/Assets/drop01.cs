using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drop01 : MonoBehaviour {

	Dropdown mydd;

	// Use this for initialization
	void Start () {

		mydd = transform.GetComponent<Dropdown> ();

		mydd.options.Clear ();

		Dropdown.OptionData data1 = new Dropdown.OptionData ();
		data1.text = "选项1"；

		Dropdown.OptionData data1 = new Dropdown.OptionData ();
		data1.text = "选项2"；


		mydd.options.Add（data1）;
		mydd.options.Add（data2）;

		mydd.onValueChanged.AddListener (dropdownlistsel);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void dropdownlistsel(int index){
		Debug.Log ("Index = " + mydd.value.ToString () + "选择内容：" + mydd.options [mydd.value].text);
}
