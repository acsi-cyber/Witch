using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisableButton : MonoBehaviour
{
    public Button button1_2;
    public Button button1_3;
    public Button button1_4;
    public Button button2_1;
    public Button button2_2;
    public Button button2_3;
    public Button button2_4;
    public GameObject panel;
    public GameObject panel2;
    int i = 0;
    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");

        button1_2.interactable = false; 
        button1_3.interactable = false;
        button1_4.interactable = false;
        button2_1.interactable = false;
        button2_2.interactable = false;
        button2_3.interactable = false;
        button2_4.interactable = false;

        switch (levelComplete)
        {
            case 2:
                button1_2.interactable = true;
                break;
            case 3:
                button1_2.interactable = true;
                button1_3.interactable = true;
                break;
            case 4:
                button1_2.interactable = true;
                button1_3.interactable = true;
                button1_4.interactable = true;
                break;
            case 5:
                button1_2.interactable = true;
                button1_3.interactable = true;
                button1_4.interactable = true;
                button2_1.interactable = true;
                break;
            case 6:
                button1_2.interactable = true;
                button1_3.interactable = true;
                button1_4.interactable = true;
                button2_1.interactable = true;
                button2_2.interactable = true;
                break;
            case 7:
                button1_2.interactable = true;
                button1_3.interactable = true;
                button1_4.interactable = true;
                button2_1.interactable = true;
                button2_2.interactable = true;
                button2_3.interactable = true;
                break;
            case 8:
                button1_2.interactable = true;
                button1_3.interactable = true;
                button1_4.interactable = true;
                button2_1.interactable = true;
                button2_2.interactable = true;
                button2_3.interactable = true;
                button2_4.interactable = true;
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        button1_2.interactable = false;
        button1_3.interactable = false;
        button1_4.interactable = false;
        button2_1.interactable = false;
        button2_2.interactable = false;
        button2_3.interactable = false;
        button2_4.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    public void ScrolButton()
    {
        panel.SetActive(false);
        panel2.SetActive(true);
        if (i == 1)
        {
            panel.SetActive(true);
            panel2.SetActive(false);
            i-=2;
        }
        i++;
    }
}
