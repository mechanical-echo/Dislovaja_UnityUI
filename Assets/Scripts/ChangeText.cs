using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {
	public GameObject InputName;
	public GameObject InputAge;
	public GameObject OutputNameAge;
	private string Name;
	private int Age;

	public void ApplyText()
	{
		try
		{
			Name = InputName.GetComponent<Text>().text;
			Age = int.Parse(InputAge.GetComponent<Text>().text);
			OutputNameAge.GetComponent<Text>().text = Name + " ir "+Age+" gadu vecs !";
		}
		catch (Exception e) {
			Debug.LogError(e.Message);
            throw;
        };
	}
	
}
