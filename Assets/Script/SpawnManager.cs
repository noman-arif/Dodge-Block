using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] boxArray;
    public GameObject boxPrefab;
    public GameObject[] collectPrefabs;
    public float xRange = 8f;
    public float yRange = 7f;
    private float startdelay = 2f;
    private float repeatInterval = 3f;
    private ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        //calling obstacles and collectable repeatedly
        InvokeRepeating("SpawnObstacles", startdelay, repeatInterval);
        InvokeRepeating("SpawnCollectables", 4f, 3f);
    }
    // this fucntion will spawn collectabel in our game
    void SpawnCollectables()
    {
        if (score.stopGame != true)
        {
            int boxIndex = Random.Range(0, collectPrefabs.Length);
            Vector3 spawnPoz = new Vector3(Random.Range(-xRange, xRange), yRange, 0);
            Instantiate(collectPrefabs[boxIndex], spawnPoz, collectPrefabs[boxIndex].transform.rotation);
        }
    }
    // this function will display hurdles in our game
    void SpawnObstacles()
    {
        if (score.stopGame != true)
        {
            int boxIndex = Random.Range(0, boxArray.Length);
            for (int i = 0; i < boxArray.Length; i++)
            {
                if (boxIndex != i)                          // this condition will decide which game object will not be display in game 
                                                            //whenever instantiate
                {
                    Instantiate(boxPrefab, boxArray[i].position, boxArray[i].transform.rotation);
                }
            }
        }
    }
}
