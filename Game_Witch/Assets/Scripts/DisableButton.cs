using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void Start()
    {
        button1_2.enabled = false;
        button1_3.enabled = false;
        button1_4.enabled = false;
        button2_1.enabled = false;
        button2_2.enabled = false;
        button2_3.enabled = false;
        button2_4.enabled = false;
    }

    public void DisableButton1()
    {
        button1_2.enabled = true;
    }

    public void DisableButton2()
    {
        button1_3.enabled = true;
    }

    public void DisableButton3()
    {
        button1_4.enabled = true;
    }

    public void DisableButton4()
    {
        button2_1.enabled = true;
    }

    public void DisableButton5()
    {
        button2_2.enabled = true;
    }

    public void DisableButton6()
    {
        button2_3.enabled = true;
    }

    public void DisableButton7()
    {
        button2_4.enabled = true;
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
