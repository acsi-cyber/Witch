using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroe : MonoBehaviour
{
    public GameObject prefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
