using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{
    public static int life = 3;
    public static int shieldscore = 0;
    public int numOfHeart;
    public int numOfShield;
    public Image[] hearts;
    public Image[] shield;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Sprite fullShield;
    public Sprite emptyShield;

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
        // Shield
        if (shieldscore > numOfShield)
        {
            shieldscore = numOfShield;
        }

        for (int i = 0; i < shield.Length; i++)
        {
            if (i < Mathf.RoundToInt(shieldscore))
            {
                shield[i].sprite = fullShield;
            }
            else
            {
                shield[i].sprite = emptyShield;
            }
            if (i < numOfShield)
            {
                shield[i].enabled = true;
            }
            else
            {
                shield[i].enabled = false;
            }
        }
    }

}
