using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject gameStart;
    public GameObject gameOver;

    void Start() {
        Time.timeScale = 1;
    }

    public void increaseScore() {
        score++;
        scoreText.text = score.ToString();
    }

    public void setGameOver() {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    public void startGame() {

        Time.timeScale = 1;
    }

    public void restartGame() {
        SceneManager.LoadScene(0);
    }
}
