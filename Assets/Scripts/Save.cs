using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Save : MonoBehaviour
{
    public TMP_InputField inputText;
    [SerializeField] private Toggle toggleKey1;
    [SerializeField] private Toggle toggleKey2;
    [SerializeField] private Toggle toggleKey3;
    [SerializeField] private Toggle toggleKey4;

    private string tutorialText;

    public void SaveThis()
    {
        //save methode and Console message key1 saved
        tutorialText = inputText.text;
        print("Key1 saved");
        PlayerPrefs.SetString("TutorialText", tutorialText);
    }

    public void LoadThis()
    {
        //Load last text
        inputText.text = PlayerPrefs.GetString("TutorialText", "");
    }
    //Toggle Stuff
    //hen toggleKey is on load the last saved message
    public void LoadToggles()
    {
        if (toggleKey1.isOn)
        {
            inputText.text = PlayerPrefs.GetString("TutorialText", "");
        }
        if (toggleKey2.isOn)
        {
            inputText.text = PlayerPrefs.GetString("TutorialText", "");
        }
        if (toggleKey3.isOn)
        {
            inputText.text = PlayerPrefs.GetString("TutorialText", "");
        }
        if (toggleKey4.isOn)
        {
            //inputText.text = PlayerPrefs.GetInt("");
        }

    }
    
    public void DeleteThis()
    {
        //delete all meesages even the saved ones + clear Textfield
        //message keys are deleted
        PlayerPrefs.DeleteAll();
        inputText.text = "";
        print("Keys deleted");
    }

    public void ClearThis()
    {
        //clears Inputfield 
        inputText.text = "";
    }
}
