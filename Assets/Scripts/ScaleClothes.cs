using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleClothes : MonoBehaviour {
	public GameObject dropdown;
	public GameObject widthSlider;
	public GameObject heightSlider;

	public GameObject[] body;
	public GameObject[] helmet;
	public GameObject[] gauntlets;
	public GameObject[] shoulder;
	public GameObject[] boots;
	public GameObject[] pants;
	public GameObject[] armguards;
	public GameObject[] waist;

	private Dropdown dp;

	void Start(){
		widthSlider.GetComponent<Slider>().interactable = false;
		heightSlider.GetComponent<Slider>().interactable = false;
		dp = dropdown.GetComponent<Dropdown> ();
	}

	public void DropdownChoice(int what){
		if (what == 0) {
			widthSlider.GetComponent<Slider>().interactable = false;
			heightSlider.GetComponent<Slider>().interactable = false;
			return;
		}
		widthSlider.GetComponent<Slider>().interactable = true;
		heightSlider.GetComponent<Slider>().interactable = true;
		Debug.Log (dp.value);
	}


	public void ChangeWidth()
	{
		int value = dp.value;
		GameObject o1, o2, o3;
		GameObject[] array = null;
		switch (value) {
		case 1:
			array = body;
			break;
		case 2:
			array = helmet;
			break;
		case 3:
			array = gauntlets;
			break;
		case 4:
			array = shoulder;
			break;
		case 5:
			array = boots;
			break;
		case 6:
			array = pants;
			break;
		case 7:
			array = armguards;
			break;
		case 8:
			array = waist;
			break;
		}
		o1 = array [0];
		o2 = array [1];
		o3 = array [2];
		float sizeBefore = widthSlider.GetComponent<Slider>().value;
		float heightBefore = o1.transform.localScale.y;
		o1.transform.localScale = new Vector2(3.5f * sizeBefore, heightBefore);
		o2.transform.localScale = new Vector2(3.5f * sizeBefore, heightBefore);
		o3.transform.localScale = new Vector2(3.5f * sizeBefore, heightBefore);
	}
	public void ChangeHeight()
	{
		int value = dp.value;
		GameObject o1, o2, o3;
		GameObject[] array = null;
		switch (value) {
		case 1:
			array = body;
			break;
		case 2:
			array = helmet;
			break;
		case 3:
			array = gauntlets;
			break;
		case 4:
			array = shoulder;
			break;
		case 5:
			array = boots;
			break;
		case 6:
			array = pants;
			break;
		case 7:
			array = armguards;
			break;
		case 8:
			array = waist;
			break;
		}
		o1 = array [0];
		o2 = array [1];
		o3 = array [2];
		float sizeBefore = heightSlider.GetComponent<Slider>().value;
		float widthBefore = o1.transform.localScale.x;
		o1.transform.localScale = new Vector2(widthBefore, 3.5f * sizeBefore);
		o2.transform.localScale = new Vector2(widthBefore, 3.5f * sizeBefore);
		o3.transform.localScale = new Vector2(widthBefore, 3.5f * sizeBefore);
	}



}
