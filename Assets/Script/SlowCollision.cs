using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlowCollision : MonoBehaviour
{ 
    IEnumerator AddDelay()                       //this is used to add delay in our game Wait for second will create delay for second in our game
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(2f); // pause execution not completely for a specific amount of time
        Time.timeScale = 1f;                   // return to it actual time

    }

    public void SlowDown()                  //this function will call IEnumerator
    {
        StartCoroutine(AddDelay());        //from here the above will start
    }
}
