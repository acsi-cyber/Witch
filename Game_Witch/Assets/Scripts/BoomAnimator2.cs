using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomAnimator2 : MonoBehaviour
{
    private int spriteIndex;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject Object;
    int i = 0;

    private void Update()
    {
        if (Object.activeSelf == true & i == 0)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            InvokeRepeating(nameof(AnimateSprite), 0.1f, 0.1f);
            i++;
        }
        
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            CancelInvoke();
            Object.SetActive(false);
            return;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
