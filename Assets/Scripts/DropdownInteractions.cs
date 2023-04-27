using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownInteractions : MonoBehaviour {
    public GameObject Warrior;
    public GameObject Hunter;
    public GameObject Palladin;

    public void Show(int num)
    {
        switch(num)
        {
            case 0:
                ShowAll();
                break;
            case 1:
                ShowWarrior();
                break;
            case 2:
                ShowHunter();
                break;
            case 3:
                ShowPalladin();
                break;
        }
    }
    private void ShowAll()
    {
        Warrior.SetActive(true);
        Hunter.SetActive(true);
        Palladin.SetActive(true);  
    }
    private void ShowWarrior()
    {
        Warrior.SetActive(true);
        Hunter.SetActive(false);
        Palladin.SetActive(false);
    }
    private void ShowHunter()
    {
        Warrior.SetActive(false);
        Hunter.SetActive(true);
        Palladin.SetActive(false);
    }
    private void ShowPalladin()
    {
        Warrior.SetActive(false);
        Hunter.SetActive(false);
        Palladin.SetActive(true);
    }
}
