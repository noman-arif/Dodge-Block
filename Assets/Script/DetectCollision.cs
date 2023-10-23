using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private SlowCollision slow;
    private ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        slow = GameObject.FindGameObjectWithTag("SlowCollision").GetComponent<SlowCollision>(); // for using coroutine in this script
        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>(); // for calculating lives on collision
    }
    private void OnCollisionEnter2D()
    {
        slow.SlowDown();
        score.Addlive();
    }
}
