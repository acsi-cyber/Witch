using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroe : MonoBehaviour
{
    public GameObject destroyPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "LoadMainMenu")
        {
            return;
        }

        else if (collision.gameObject.tag == "Score" || 
                 collision.gameObject.tag == "Score_2" || 
                 collision.gameObject.tag == "SpeedUp" || 
                 collision.gameObject.tag == "SpeedDown")
        {
            Destroy(gameObject);
            Debug.Log("Delet");
        }

        /*else
        {
            Destroy(gameObject);
            FindObjectOfType<Spawner>().SpawnTime();
            Debug.Log("Delet");
        }*/
    }
}
