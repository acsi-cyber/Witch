using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocFixet1 : MonoBehaviour
{
    private float leftEdge;
    private float playerZ;
    private float playerY;

    private void Start()
    {
        playerZ = transform.position.z;
        playerY = transform.position.y;
    }

    void Update()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, playerZ)).x + 15f;
        if (transform.position.x < leftEdge)
        {
            transform.position = new Vector3(leftEdge, playerY, playerZ);
        }
        else if (transform.position.x > leftEdge)
        {
            transform.position = new Vector3(leftEdge, playerY, playerZ);
        }
    }
}
