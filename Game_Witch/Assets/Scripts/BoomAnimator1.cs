using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomAnimator1 : MonoBehaviour
{
    private int spriteIndex;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject Object;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void StartScript()
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
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
