using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBoundries : MonoBehaviour
{
    public float rangeY = 8f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -rangeY)        //it is only destroy the box with goes out of boundries
        {
            Destroy(gameObject);
        }
    }
}
