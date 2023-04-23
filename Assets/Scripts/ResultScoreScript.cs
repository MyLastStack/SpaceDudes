using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScoreScript : MonoBehaviour
{
    [SerializeField] ScoreScriptableObject ScoreSO;

    [SerializeField] TextMeshProUGUI FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        FinalScore.text = $"Final score: {ScoreSO.GameScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
