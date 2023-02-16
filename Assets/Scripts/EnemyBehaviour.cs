using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 velocity;
    [SerializeField] GameObject EnemyLaser;
    float Timestamp;
    float FireDelay = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        FireDelay = Random.Range(1.2f, 4.0f);
        velocity.x = 3;
        Timestamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(velocity * Time.deltaTime);
        if(Timestamp + FireDelay <= Time.time)
        {
            ShootRandomly();
        }
        
    }

    void ShootRandomly()
    {
        if (!EnemyLaser) { return; }
        if (Random.Range(1,100) > 80)
        {
            Instantiate(EnemyLaser, rb.transform.position, Quaternion.identity);
            Timestamp = Time.time;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Wall")
        {
            velocity.x *= -1;
            rb.transform.Translate(Vector2.down);
        }
    }
}
