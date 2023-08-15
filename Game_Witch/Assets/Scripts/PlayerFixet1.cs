using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixet1 : MonoBehaviour
{
    public new Camera camera;
    public GameObject player;
    public void FixedPlayer()
    {
        Vector3 p1 = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth / 6, camera.pixelHeight / 2, 6f));
        player.transform.position = p1;
    }
}
