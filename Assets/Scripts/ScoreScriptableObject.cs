using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScriptableObject : ScriptableObject
{
    [SerializeField] private float Score;

    public float GameScore
    {
        get { return Score; }
        set { Score = value; }
    }
}
