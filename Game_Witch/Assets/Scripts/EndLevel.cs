using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameObject size1;
    public GameObject size2;
    public GameObject scene1;
    public GameObject scene2;
    public float i;
    public bool update = false;
    int levelComplete;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            update = true;
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                Invoke("LoadAnim", 5f);
            }
            else if (SceneManager.GetActiveScene().buildIndex != 1)
            {
                Invoke("LoadAnim", 2f);
            }
        }
    }

    public void Update()
    {
        if (!update) return;
        if (i < 12f & SceneManager.GetActiveScene().buildIndex != 1)
        {
            size1.transform.localScale = new Vector3(23f, i, 1f);
            size2.transform.localScale = new Vector3(23f, i, 1f);
            i += 0.1f;
        }
        else if (i > 1f & SceneManager.GetActiveScene().buildIndex == 1)
        {
            levelComplete = PlayerPrefs.GetInt("LevelComplete");
            Debug.Log(levelComplete);
            if (levelComplete == 5)
            {
                scene1.SetActive(false);
                scene2.SetActive(true);
            }
            else if (levelComplete != 5)
            {
                scene1.SetActive(true);
                scene2.SetActive(false);
            }
            size1.transform.localScale = new Vector3(23f, i, 1f);
            size2.transform.localScale = new Vector3(23f, i, 1f);
            i -= 0.1f;
        }
    }

    void LoadAnim()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("MainMenu");
            LifePlayer.life = 3;
        }

        else if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene("Anim1");
        }
    }

}
