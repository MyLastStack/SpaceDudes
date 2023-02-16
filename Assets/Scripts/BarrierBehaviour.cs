using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierBehaviour : MonoBehaviour
{
    int Health;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Health = 3;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material.color = Color.white;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("EnemyLaser")) 
        {
            Destroy(collision.gameObject);
            Health--;
            switch (Health)
            {
                case 3:
                    spriteRenderer.material.color = Color.white;
                    break;
                case 2:
                    spriteRenderer.material.color = Color.yellow;
                    break;
                case 1:
                    spriteRenderer.material.color = Color.red;
                    break;
                case 0:
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
