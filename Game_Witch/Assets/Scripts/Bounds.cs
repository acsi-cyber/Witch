using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public GameObject object1;

    public void Start()
    {
        Camera.main.orthographicSize = 5f;
        float x1 = 1f;
        object1.transform.localScale = new Vector3(x1, x1, 1f);
    }

    public void Update()
    {
        Camera.main.orthographicSize = 18f * Camera.main.pixelHeight / Camera.main.pixelWidth * .5f;
    }

}