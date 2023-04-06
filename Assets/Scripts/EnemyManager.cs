using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI EnemiesLeft;
    [SerializeField] TextMeshProUGUI Score;

    protected GameState gameState;
    int MaxEnemies;
    int EnemyCount;

    // Start is called before the first frame update
    void Start()
    {
        MaxEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        gameState = GameObject.FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemiesLeft.text = $"Enemies\nleft: {EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length}";
        if (EnemyCount < MaxEnemies)
        {
            Score.text = $"Score:\n{gameState.score = (MaxEnemies - EnemyCount) * 50}";
        }

        if (EnemyCount == 0)
        {
            GameSceneManager.LoadWinScreen();
        }
    }
}
