using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    private Vector3 direction;
    public float graviti = -9.8f;
    public float strength = 5f;

    public GameObject canvas;
    public GameObject frog;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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

    void Frog()
    {
        if (LifePlayer.shieldscore == 0)
        {
            LifePlayer.shieldscore += 1;
            frog.SetActive(true);
        }
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
            if (LifePlayer.shieldscore > 0)
            {
                LifePlayer.shieldscore -= 1;
                frog.SetActive(false);
                Invoke("Frog", 5.0f);
            }
            else if (LifePlayer.shieldscore < 1)
            {
                LifePlayer.life -= 1;
                if (LifePlayer.life == 0)
                {
                    CancelInvoke("Frog");
                }
            }

            FindObjectOfType<GameMeneger>().GameOver();
        }
        else if (collision.gameObject.tag == "Score")
        {
            FindObjectOfType<GameMeneger>().IncreaseScore();
            
        }
        else if (collision.gameObject.tag == "LoadMainMenu")
        {
            LevelSkrol.instance.idEndGame();
            canvas.SetActive(false);

        }
        else if (collision.gameObject.tag == "Score_2")
        {
            FindObjectOfType<GameMeneger>().IncreaseScore_2();

        }
        else if (collision.gameObject.tag == "Poison")
        {
            if (LifePlayer.shieldscore > 0)
            {
                LifePlayer.shieldscore -= 1;
                frog.SetActive(false);
                Invoke("Frog", 5.0f);
            }
            else if (LifePlayer.shieldscore < 1)
            {
                LifePlayer.life -= 1;
                if (LifePlayer.life == 0)
                {
                    CancelInvoke("Frog");
                }
            }

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
            if (LifePlayer.shieldscore > 0)
            {
                LifePlayer.shieldscore -= 1;
                frog.SetActive(false);
                Invoke("Frog", 5.0f);
            }
            else if (LifePlayer.shieldscore < 1)
            {
                LifePlayer.life -= 1;
                if (LifePlayer.life == 0)
                {
                    CancelInvoke("Frog");
                }
            }

            direction = Vector3.up * strength;

            FindObjectOfType<GameMeneger>().GameOver();
        }
        else if (collision.gameObject.tag == "cloudDown")
        {
            if (LifePlayer.shieldscore > 0)
            {
                LifePlayer.shieldscore -= 1;
                frog.SetActive(false);
                Invoke("Frog", 5.0f);
            }
            else if (LifePlayer.shieldscore < 1)
            {
                LifePlayer.life -= 1;
                if (LifePlayer.life == 0)
                {
                    CancelInvoke("Frog");
                }
            }

            direction = Vector3.down * strength;

            FindObjectOfType<GameMeneger>().GameOver();
        }
    }
}

