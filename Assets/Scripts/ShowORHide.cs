using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowORHide : MonoBehaviour {

    /*
    * FOR SHOW/HIDE ALL BUTTONS
    */
    public GameObject[] warriorImages;
    public GameObject[] hunterImages;
    public GameObject[] paladinImages;

    public GameObject WarriorToggleGroupHolder;
    public GameObject HunterToggleGroupHolder;
    public GameObject PaladinToggleGroupHolder;

    private void HideShow(bool shown)
    {
        foreach (GameObject image in warriorImages)
        {
            image.SetActive(shown);
        }
        foreach (GameObject image in hunterImages)
        {
            image.SetActive(shown);
        }
        foreach (GameObject image in paladinImages)
        {
            image.SetActive(shown);
        }
        Toggle[] warriorToggles = WarriorToggleGroupHolder.GetComponentsInChildren<Toggle>();
        Toggle[] hunterToggles = HunterToggleGroupHolder.GetComponentsInChildren<Toggle>();
        Toggle[] paladinToggles = PaladinToggleGroupHolder.GetComponentsInChildren<Toggle>();

        foreach (Toggle tog in warriorToggles)
        {
            tog.isOn = shown;
        }
        foreach (Toggle tog in hunterToggles)
        {
            tog.isOn = shown;
        }
        foreach (Toggle tog in paladinToggles)
        {
            tog.isOn = shown;
        }
    }
    public void ShowAll()
    {
        HideShow(true);
        
    }
    public void HideAll()
    {
        HideShow(false);
        
    }
}
