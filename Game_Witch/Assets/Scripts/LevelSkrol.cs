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

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void idEndGame()
    {
        if (levelComplete < sceneIndex)
            PlayerPrefs.SetInt("LevelComplete", sceneIndex);
        //SceneManager.LoadScene(sceneIndex + 1);//
    }
}
