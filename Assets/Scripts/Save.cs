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
        tutorialText = inputText.text;
        PlayerPrefs.SetString("TutorialText", tutorialText);

    }

    public void LoadThis()
    {
        inputText.text = PlayerPrefs.GetString("TutorialText", "");
    }
    //Toggle Stuff
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
        PlayerPrefs.DeleteAll();
        inputText.text = "";
        print("Keys deleted");
    }

    public void ClearThis()
    {
        inputText.text = "";
    }
}
