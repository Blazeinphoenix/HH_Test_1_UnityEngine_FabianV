HH_Test1

Code Methods
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


Screenshots

Video:
##
