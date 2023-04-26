using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour {

    public GameObject human;
    public GameObject orc;
    public GameObject dwarf;
    public GameObject night_elf;
    public GameObject undead;
    public GameObject tauren;

    public GameObject image_object;
    public Sprite[] character_images;

    public void human_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[0];
    }
    public void dwarf_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[1];
    }
    public void night_elf_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[2];
    }
    public void orc_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[3];
    }
    public void undead_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[4];
    }
    public void tauren_image()
    {
        image_object.GetComponent<Image>().sprite = character_images[5];
    }

}
