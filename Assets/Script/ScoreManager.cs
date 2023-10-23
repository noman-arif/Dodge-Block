using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerLives = 3;
    public Text lives;
    public int playerScore = 0;
    public Text score;
    public int earnStar = 0;
    public Text star;
    public GameObject gameOver;
    public bool stopGame;
    // Start is called before the first frame update
    void Start()
    {
        stopGame = false;
    }
    public void AddScore()                      //this function will increment score each time ball hit player 
                                                //after every 5 balls he earn a star
    {
        playerScore++;
        score.text = "Score: " + playerScore;
        if (playerScore % 5 == 0)
        {
            earnStar++;
            star.text = "Star: " + earnStar;
        }
    }
    public void Addlive()                   //this function will check lives of player 
                                            //if player hit box it live will decrease by one
    {
        playerLives--;
        lives.text = "Lives: " + playerLives;
        if (playerLives == 0)               // if live reach zero than Game will be OVer 
        {
            GameOver();
            stopGame = true;

        }

    }
    void GameOver()                         //Function for making Game OVer UI true or false
    {
        gameOver.SetActive(true);
    }
}
