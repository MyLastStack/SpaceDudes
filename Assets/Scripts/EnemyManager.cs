using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI EnemiesLeft;
    [SerializeField] TextMeshProUGUI Score;

    protected GameState gameState;
    int MaxEnemies = 0;
    int EnemyCount = 0;

    [SerializeField] GameSceneManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        MaxEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        gameState = GameObject.FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemiesLeft.text = $"Left:\n{EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length}";
        if (EnemyCount < MaxEnemies)
        {
            Score.text = $"Score:\n{gameState.score = (MaxEnemies - EnemyCount) * 50}";
        }
        else
        {
            Score.text = $"Score:\n0";
        }

        if (EnemyCount == 0)
        {
            gsm.LoadNextLevel();
        }
    }
}
