using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI EnemiesLeft;
    public int EnemyCount;

    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        EnemiesLeft.text = "Hi";
    }
}
