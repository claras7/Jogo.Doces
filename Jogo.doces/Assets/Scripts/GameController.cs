using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject end;
    public GameObject next;
    public int totalScore;
    public Text ScoreText;

    public static GameController instance;
    
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }
    public void UpdateScoreText()
    {
        ScoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void ShowEnd()
    {
        end.SetActive(true);
    }

    public void ShowNextLevel()
    {
       next.SetActive(true);
    }

    public void NextLevel(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
    

    public void StartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
        
    }
}
