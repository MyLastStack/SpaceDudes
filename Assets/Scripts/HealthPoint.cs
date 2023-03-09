using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoint : MonoBehaviour
{
    PlayerBehaviour playerBehaviour;
    [SerializeField] GameObject player;
    [SerializeField] GameObject healthPoint3;
    [SerializeField] GameObject healthPoint2;
    [SerializeField] GameObject healthPoint;
    int PlayerHealth;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 3;
        playerBehaviour = player.GetComponent<PlayerBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthUpdate();
    }

    void HealthUpdate()
    {
        if (playerBehaviour.PlayerHP == 2)
        {
            Destroy(healthPoint3);
        }
        if (playerBehaviour.PlayerHP == 1)
        {
            Destroy(healthPoint2);
        }
        if (playerBehaviour.PlayerHP == 0)
        {
            Destroy(healthPoint);
        }
    }
}
