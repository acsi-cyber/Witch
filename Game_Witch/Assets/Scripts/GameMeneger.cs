using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMeneger : MonoBehaviour
{
    public PlayerControl player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 120;

        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

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

    public void GameOver()
    {
        if (LifePlayer.life == 0)
        {
            LifePlayer.life = 3;
            gameOver.SetActive(true);
            playButton.SetActive(true);
            Pause();
        }
        Debug.Log(LifePlayer.life);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
