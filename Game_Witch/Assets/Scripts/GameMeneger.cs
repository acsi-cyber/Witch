using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMeneger : MonoBehaviour
{
    public PlayerControl player;
    public Text scoreText_1;
    public Text scoreText_2;
    public GameObject playButton;
    public GameObject exitButton;
    public GameObject gameOver;
    public GameObject timeLine;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    public int score_1;
    public int score_2;
    private int score1Storage;
    private int score2Storage;

    private void Awake()
    {
        Application.targetFrameRate = 80;

        Pause();
    }

    public void Play()
    {
        scoreText_1.text = score_1.ToString();
        scoreText_2.text = score_2.ToString();

        playButton.SetActive(false);
        exitButton.SetActive(false);
        gameOver.SetActive(false);
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);

        score1Storage = score_1;
        score2Storage = score_2;

        Time.timeScale = 1f;
        player.enabled = true;

        trap[] traps = FindObjectsOfType<trap>();

        for (int i =0; i < traps.Length; i++)
        {
            Destroy(traps[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        if (score_1 < 3 || score_2 < 3)
        {
            score_1 = score1Storage;
            score_2 = score2Storage;
        }
    }

    public void GameOver()
    {
        if (LifePlayer.life == 0)
        {
            LifePlayer.life = 3;
            gameOver.SetActive(true);
            playButton.SetActive(true);
            exitButton.SetActive(true);
            Pause();
        }
        Debug.Log(LifePlayer.life);
    }

    public void Heart()
    {
        if (LifePlayer.life < 3)
        {
            LifePlayer.life += 1;
        }
    }

    public void SpeedUp()
    {
        Time.timeScale = 2f;
        Invoke("SpeedNormal", 8);
    }

    public void SpeedDown()
    {
        Time.timeScale = 0.5f;
        Invoke("SpeedNormal", 2);
    }

    void SpeedNormal()
    {
        Time.timeScale = 1f;
    }

    public void IncreaseScore()
    {
        if (score_1 != 0)
        {
            score_1--;
        }

        scoreText_1.text = score_1.ToString();
        if (score_1 == 0 & score_2 == 0)
        {
            timeLine.SetActive(true);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            FindObjectOfType<DisableButton>().DisableButton1();
        }
    }

    public void IncreaseScore_2()
    {
        if (score_2 != 0)
        {
            score_2--;
        }

        scoreText_2.text = score_2.ToString();
        if (score_1 == 0 & score_2 == 0)
        {
            timeLine.SetActive(true);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            FindObjectOfType<DisableButton>().DisableButton1();
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
