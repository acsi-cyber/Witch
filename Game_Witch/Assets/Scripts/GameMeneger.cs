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
    public GameObject playStartButton;
    public GameObject playPauseButton;
    public GameObject exitButton;
    public GameObject timeLine;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject frog;
    public GameObject frog2;
    public GameObject frog3;
    public GameObject timeEffectUp;
    public GameObject timeEffectDown;

    public int score_1;
    public int score_2;
    private int score1Storage;
    private int score2Storage;
    int i = 0;

    private void Awake()
    {
        Application.targetFrameRate = 80;
        LifePlayer.shieldscore = 0;
        Pause();
    }

    public void Play()
    {
        scoreText_1.text = score_1.ToString();
        scoreText_2.text = score_2.ToString();

        playButton.SetActive(false);
        exitButton.SetActive(false);
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        e.SetActive(true);
        f.SetActive(true);

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
    }

    public void PauseEsc()
    {
        if (i == 0)
        {
            playStartButton.SetActive(false);
            playButton.SetActive(true);
            exitButton.SetActive(true);
            playPauseButton.SetActive(true);
            Time.timeScale = 0f;
            player.enabled = false;
            i++;
        }

        else if (i == 1)
        {
            playStartButton.SetActive(true);
            playButton.SetActive(false);
            exitButton.SetActive(false);
            playPauseButton.SetActive(false);
            Time.timeScale = 1f;
            player.enabled = true;
            i--;
        }

    }

    public void GameOver()
    {
        if (LifePlayer.life == 0)
        {
            LifePlayer.life = 3;
            playButton.SetActive(true);
            exitButton.SetActive(true);
            Pause();
            frog.SetActive(false);
            frog2.SetActive(false);
            LifePlayer.shieldscore = 0;
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
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 2f;
            Invoke("SpeedNormal", TimeEffect.timeSpeedUp);
            timeEffectUp.SetActive(true);
            StartCoroutine(FindObjectOfType<TimeEffect>().TimeChek());
        }
    }

    public void SpeedDown()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0.5f;
            Invoke("SpeedNormal", TimeEffect.timeSpeedDown);
            timeEffectDown.SetActive(true);
            StartCoroutine(FindObjectOfType<TimeEffect>().TimeChek());
        }
        
    }

    void SpeedNormal()
    {
        Time.timeScale = 1f;
        timeEffectUp.SetActive(false);
        timeEffectDown.SetActive(false);
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
            e.SetActive(false);
            f.SetActive(false);
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
            e.SetActive(false);
            f.SetActive(false);
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Spawn()
    {
        LifePlayer.shieldscore += 1;
        frog.SetActive(true);
        frog2.SetActive(true);
        frog3.SetActive(true);
    }
}
