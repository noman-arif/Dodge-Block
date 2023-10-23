using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>(); //for access component of score script here
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))      //checking whether the ball is colliding with player or not
        {
            Destroy(gameObject);                            //if true than it will destroy and increment in score by one         
            score.AddScore();
        }
    }
}
