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
    public GameObject player;
    public float i;
    public bool update = false;
    int levelComplete;
    int levelReal;

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
        if (DisableButton.proverca == 0)
        {
            player.SetActive(true);
        }
        else if (DisableButton.proverca == 2)
        {
            player.SetActive(true);
        }
        if (!update) return;
        if (i < 13f & SceneManager.GetActiveScene().buildIndex != 1)
        {
            size1.transform.localScale = new Vector3(150f, i, 1f);
            size2.transform.localScale = new Vector3(150f, i, 1f);
            i += 0.1f;
        }
        else if (i > 1f & SceneManager.GetActiveScene().buildIndex == 1)
        {
            levelComplete = PlayerPrefs.GetInt("LevelComplete");
            levelReal = PlayerPrefs.GetInt("LevelReal");
            if (levelComplete == 5)
            {
                if (levelReal != 5)
                {
                    scene1.SetActive(true);
                    scene2.SetActive(false);
                }
                else if (levelReal == 5)
                {
                    scene1.SetActive(false);
                    scene2.SetActive(true);
                }
                
            }
            else if (levelComplete != 5)
            {
                scene1.SetActive(true);
                scene2.SetActive(false);
            }
            size1.transform.localScale = new Vector3(150f, i, 1f);
            size2.transform.localScale = new Vector3(150f, i, 1f);
            i -= 0.1f;
        }
    }

    void LoadAnim()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Time.timeScale = 1f;
            if (DisableButton.proverca == 0)
            {
                player.SetActive(false);
                SceneManager.LoadScene("MainMenu");
            }
            else if (DisableButton.proverca == 2 || DisableButton.proverca == 1)
            {
                player.SetActive(false);
                scene1.SetActive(false);
                scene2.SetActive(false);
            }
            LifePlayer.life = 3;
        }

        else if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Anim1");
        }
    }

}
