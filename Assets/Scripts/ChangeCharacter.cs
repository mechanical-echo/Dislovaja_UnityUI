using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour {

    public GameObject HordeBG;

    public GameObject human;
    public GameObject orc;
    public GameObject dwarf;
    public GameObject night_elf;
    public GameObject undead;
    public GameObject tauren;

    public GameObject image_object;
    public Sprite[] character_images;
    void Start ()
    {
        HordeBG.SetActive (false);
    }
    public void human_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[0];
        HordeBG.SetActive(false);
    }
    public void dwarf_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[1];
        HordeBG.SetActive(false);
    }
    public void night_elf_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[2];
        HordeBG.SetActive(false);
    }
    public void orc_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[3];
        HordeBG.SetActive(true);
    }
    public void undead_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[4];
        HordeBG.SetActive(true);
    }
    public void tauren_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[5];
        HordeBG.SetActive(true);
    }

}
