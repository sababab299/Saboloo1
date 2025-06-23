using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _highScore;
    private int score;

    public static ScoreManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _currentScore.text = score.ToString();
        _highScore.text = PlayerPrefs.GetInt("highScore",0).ToString();
        RefreshHighScore();
    }

    private void RefreshHighScore()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
            _highScore.text = score.ToString();
        }
    }
    public void RefreshScore()
    {
        score++;
        _currentScore.text=score.ToString();
        RefreshHighScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
