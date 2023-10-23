using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerRangeX = 15f;
    public float speed = 10f;
    private ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //range or boundries
        if (transform.position.x < -playerRangeX)
        {
            transform.position = new Vector3(-playerRangeX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > playerRangeX)
        {
            transform.position = new Vector3(playerRangeX, transform.position.y, transform.position.z);
        }
        //to stop game to playable we use this bool condition after gameover control will freeze
        if (score.stopGame != true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput); // player movement 
        }

    }
}
