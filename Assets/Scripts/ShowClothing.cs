using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowClothing : MonoBehaviour{
    
    public GameObject helmet_bttn;
    public GameObject body_bttn;
    public GameObject gaunlets_bttn;
    public GameObject shoulder_bttn;
    public GameObject pants_bttn;
    public GameObject boots_bttn;
    public GameObject armguards_bttn;
    public GameObject waist_bttn;

    public GameObject helmet_img;
    public GameObject body_img;
    public GameObject gaunlets_img;
    public GameObject shoulder_img;
    public GameObject pants_img;
    public GameObject boots_img;
    public GameObject armguards_img;
    public GameObject waist_img;

    void Start()
    {
        helmet_bttn.GetComponent<Toggle>().isOn = false;
        body_bttn.GetComponent<Toggle>().isOn = false;
        gaunlets_bttn.GetComponent<Toggle>().isOn = false;
        shoulder_bttn.GetComponent<Toggle>().isOn = false;
        pants_bttn.GetComponent<Toggle>().isOn = false;
        boots_bttn.GetComponent<Toggle>().isOn = false;
        armguards_bttn.GetComponent<Toggle>().isOn = false;
        waist_bttn.GetComponent<Toggle>().isOn = false;

        helmet_img.SetActive(false);
        body_img.SetActive(false);
        gaunlets_img.SetActive(false);
        shoulder_img.SetActive(false);
        pants_img.SetActive(false);
        boots_img.SetActive(false);
        armguards_img.SetActive(false);
        waist_img.SetActive(false);
    }

    public void showHelmet(bool isOn)
    {
        helmet_img.SetActive(isOn);
    }
    public void showBody(bool isOn)
    {
        body_img.SetActive(isOn);
    }
    public void showGaunlets(bool isOn)
    {
        gaunlets_img.SetActive(isOn);
    }
    public void showShoulder(bool isOn)
    {
        shoulder_img.SetActive(isOn);
    }
    public void showPants(bool isOn)
    {
        pants_img.SetActive(isOn);
    }
    public void showBoots(bool isOn)
    {
        boots_img.SetActive(isOn);
    }
    public void showArmguards(bool isOn)
    {
        armguards_img.SetActive(isOn);
    }
    public void showWaist(bool isOn)
    {
        waist_img.SetActive(isOn);
    }

}
