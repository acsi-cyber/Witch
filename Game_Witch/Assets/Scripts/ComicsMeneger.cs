using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicsMeneger : MonoBehaviour
{
    public GameObject fon1;
    public GameObject fon2;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public static int sceil = 1;

    private void Start()
    {
        fon1.SetActive(false);
        fon2.SetActive(false);
        img1.SetActive(false);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
        if (DisableButton.proverca == 1)
        {
            fon1.SetActive(true);
            FindObjectOfType<ComicsMeneger>().SwitchStart();
        }
        else if (DisableButton.proverca == 2)
        {
            Invoke("Comics2", 5.1f);
        }
        
    }

    public void Comics2()
    {
        fon2.SetActive(true);
        sceil = 6;
        DisableButton.proverca = 0;
        FindObjectOfType<ComicsMeneger>().SwitchStart();
    }

    public void SwitchStart()
    {
        Debug.Log("1");
        switch (sceil)
        {
            case 1:
                Debug.Log("2");
                img1.SetActive(true);
                StartCoroutine(FindObjectOfType<ComicsAnim>().CorutinStart());
                break;
            case 2:
                img2.SetActive(true);
                StartCoroutine(FindObjectOfType<ComicsAnim1>().CorutinStart());
                break;
            case 3:
                img3.SetActive(true);
                StartCoroutine(FindObjectOfType<ComicsAnim2>().CorutinStart());
                break;
            case 4:
                img4.SetActive(true);
                StartCoroutine(FindObjectOfType<ComicsAnim3>().CorutinStart());
                Invoke("LoadScene", 5);
                sceil = 0;
                break;
            case 6:
                Debug.Log("6");
                img5.SetActive(true);
                StartCoroutine(FindObjectOfType<ComicsAnim>().CorutinStart());
                break;
            case 7:
                img6.SetActive(true);
                StartCoroutine(FindObjectOfType<ComicsAnim>().CorutinStart());
                Invoke("LoadScene1", 6);
                break;
        }
    }

    void LoadScene()
    {
        sceil = 0;
        DisableButton.proverca = 0;
        SceneManager.LoadScene(2);
    }

    void LoadScene1()
    {
        DisableButton.proverca = 0;
        SceneManager.LoadScene(0);
    }
}
