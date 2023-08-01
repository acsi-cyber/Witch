using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{
    public static int life = 3;
    public static int shieldscore = 0;
    public int numOfHeart;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        //XP
        if (life > numOfHeart)
        {
            life = numOfHeart;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(life))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHeart)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        
    }

}
