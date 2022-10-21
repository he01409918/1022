using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("分數")]
    public int score;
    private void Start()
    {
        Instance = this;
    }

    public void OnAddScore(int value)
    {
        score += value;
    }
}
