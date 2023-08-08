using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomAnimator1 : MonoBehaviour
{
    private int spriteIndex;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject img;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("StartScript", 0.01f);
        }
    }

    public void StartScript()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.06f, 0.06f);
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
            CancelInvoke();
            Destroy(img);
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
