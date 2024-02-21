HH_Test1





Screenshots:

![Bildschirmfoto 2024-02-21 um 13 56 04](https://github.com/Blazeinphoenix/HH_Test_1_UnityEngine_FabianV/assets/124133865/aca7abd4-66ce-4d81-b6db-f76ebf2fc4bc)





Video:

https://github.com/Blazeinphoenix/HH_Test_1_UnityEngine_FabianV/assets/124133865/e4be380a-aceb-4219-9d53-a7778b022d54

##
Code methods:




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
