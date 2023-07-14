using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    private Vector3 direction;
    public float graviti = -9.8f;
    public float strength = 5f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /*private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }*/

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }    

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        direction.y += graviti * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    /*private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }*/

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            LifePlayer.life -= 1;

            FindObjectOfType<GameMeneger>().GameOver();
        }
        else if (collision.gameObject.tag == "Score")
        {
            FindObjectOfType<GameMeneger>().IncreaseScore();
            
        }
        else if (collision.gameObject.tag == "LoadMainMenu")
        {
            FindObjectOfType<GameMeneger>().LoadMainMenu();

        }
        else if (collision.gameObject.tag == "Score_2")
        {
            FindObjectOfType<GameMeneger>().IncreaseScore_2();

        }
        else if (collision.gameObject.tag == "Poison")
        {
            LifePlayer.life -= 1;

            FindObjectOfType<GameMeneger>().GameOver();
        }
        else if (collision.gameObject.tag == "Heart")
        {
            FindObjectOfType<GameMeneger>().Heart();
        }
        else if (collision.gameObject.tag == "SpeedUp") 
        {
            FindObjectOfType<GameMeneger>().SpeedUp();
        }
        else if (collision.gameObject.tag == "SpeedDown")
        {
            FindObjectOfType<GameMeneger>().SpeedDown();
        }
        else if (collision.gameObject.tag == "cloud")
        {
            LifePlayer.life -= 1;

            direction = Vector3.up * strength;

            FindObjectOfType<GameMeneger>().GameOver();
        }
        else if (collision.gameObject.tag == "cloudDown")
        {
            LifePlayer.life -= 1;

            direction = Vector3.down * strength;

            FindObjectOfType<GameMeneger>().GameOver();
        }
    }
}
