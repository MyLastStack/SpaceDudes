using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScriptableObjects : MonoBehaviour
{
    [SerializeField] ScoreScriptableObject ScoreSO;
    void Start()
    {
        ScoreSO.GameScore = 0;
    }
}
