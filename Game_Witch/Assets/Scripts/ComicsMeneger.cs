using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicsMeneger : MonoBehaviour
{
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public static int sceil = 1;

    private void Start()
    {
        img1.SetActive(false);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
    }

    private void Update()
    {
        switch (sceil)
        {
            case 1:
                img1.SetActive(true);
                break;
            case 2:
                img2.SetActive(true);
                break;
            case 3:
                img3.SetActive(true);
                break;
            case 4:
                img4.SetActive(true);
                break;
            case 5:
                img5.SetActive(true);
                break;
            case 6:
                img6.SetActive(true);
                break;
        }
    }
}
