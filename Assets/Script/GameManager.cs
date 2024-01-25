using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public GameObject player;
    public bool isGameOver = false;
    public TextMeshProUGUI scoreText;

    public void AddScore(int scorePoint)
    {
        score += scorePoint;
        scoreText.text = "Score: " + score.ToString();
    }
    void Start()
    {
        AddScore(0);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        Debug.Log("GAME OVER!");
    }


}
