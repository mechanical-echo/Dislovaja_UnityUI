using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowClothing : MonoBehaviour {

    /*
     * FOR TOGGLE BUTTONS AND THEIR IMAGES
     */
    public GameObject button;
    public GameObject image;

    public void Show(bool isOn)
    {
        image.SetActive(isOn);
    }
    void Start()
    {
        button.GetComponent<Toggle>().isOn = false;
        image.SetActive(false);
    }
   
}
