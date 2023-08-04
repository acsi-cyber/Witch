using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSkrol : MonoBehaviour
{
    public static LevelSkrol instance = null;
    int sceneIndex;
    int levelComplete;
    int levelReal;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        levelReal = SceneManager.GetActiveScene().buildIndex;
    }

    public void idEndGame()
    {
        PlayerPrefs.SetInt("LevelReal", levelReal);
        if (levelComplete < sceneIndex)
            PlayerPrefs.SetInt("LevelComplete", sceneIndex);
        //SceneManager.LoadScene(sceneIndex + 1);//
    }
}
