using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomAnimator : MonoBehaviour
{
    private int spriteIndex;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject Object;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.1f, 0.1f);
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
            CancelInvoke();
            Object.SetActive(false);
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
