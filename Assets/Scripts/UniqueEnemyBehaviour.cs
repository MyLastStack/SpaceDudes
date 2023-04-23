using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueEnemyBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 velocity;
    [SerializeField] GameObject EnemyLaser;
    float Timestamp;
    float FireDelay = 0.5f;

    float hp;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        FireDelay = Random.Range(1.2f, 4.0f);
        velocity.x = 2f;
        Timestamp = Time.time;

        hp = 15;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(velocity * Time.deltaTime);
        if(Timestamp + FireDelay <= Time.time)
        {
            ShootRandomly();
        }
        
        if (rb.transform.position.y <= -3f)
        {
            GameSceneManager.LoadLoseScreen();
        }
    }

    void ShootRandomly()
    {
        if (!EnemyLaser) { return; }
        if (Random.Range(1,100) > 80)
        {
            Instantiate(EnemyLaser, rb.transform.position, Quaternion.Euler(0, 0, 30));
            Instantiate(EnemyLaser, rb.transform.position, Quaternion.identity);
            Instantiate(EnemyLaser, rb.transform.position, Quaternion.Euler(0, 0, -30));
            Timestamp = Time.time;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Wall")
        {
            velocity.x *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyLaser"))
        {
            Destroy(collision.gameObject);
            hp--;
            switch (hp)
            {
                case 15:
                    spriteRenderer.material.color = Color.white;
                    break;
                case 10:
                    spriteRenderer.material.color = Color.yellow;
                    break;
                case 5:
                    spriteRenderer.material.color = Color.red;
                    break;
            }

            if (hp == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
