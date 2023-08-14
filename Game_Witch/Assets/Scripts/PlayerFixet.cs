using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixet : MonoBehaviour
{
    public new Camera camera;
    public GameObject player;
    void Update()
    {
        Vector3 p1 = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth / 2, camera.pixelWidth / 2.5f, 14f));
        player.transform.position = p1;
    }
}
