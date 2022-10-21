using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("分數")]
    public int score;

    public Text scoreText;
    private void Start()
    {
        Instance = this;
    }

    public void OnAddScore(int value) 
    {
        score += value;
        scoreText.text = score.ToString();
    }
}
