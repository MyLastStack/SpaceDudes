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
    int previousCount;

    [SerializeField] ScoreScriptableObject ScoreSO;
    [SerializeField] GameSceneManager gsm;

    // Start is called before the first frame update
    void Start()
    {
        MaxEnemies = = GameObject.FindGameObjectsWithTag("Enemy").Length;
        previousCount = MaxEnemies;
        gameState = GameObject.FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemiesLeft.text = $"Left:\n{EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length}";
        if (previousCount > EnemyCount)
        {
            previousCount = EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
            ScoreSO.GameScore += 50;
        }
        Score.text = $"Score:\n{ScoreSO.GameScore}";

        if (EnemyCount == 0)
        {
            gsm.LoadNextLevel();
        }
    }
}
