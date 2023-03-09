using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] GameObject PlayerBullet;
    public int PlayerHP;
    Rigidbody2D rb;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = 3;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Shoot();
    }
    void MovePlayer()
    {
        velocity = Vector3.zero;
        if (Keyboard.current.aKey.isPressed)
        {
            velocity.x += -5f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            velocity.x += 5f;
        }
        rb.transform.Translate(velocity * Time.deltaTime);
    }

    void Shoot()
    {
        if (!PlayerBullet) { return; }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(PlayerBullet, rb.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyLaser"))
        {
            Destroy(collision.gameObject);
            PlayerHP--;
            if (PlayerHP == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
