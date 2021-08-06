using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float bottomBound = -10f;
    private float leftBound = -25f;
    private float rightBound = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound 
            || transform.position.z < bottomBound
            || transform.position.x < leftBound
            || transform.position.x > rightBound
            )
        {
            Destroy(gameObject);
        }
    }
}
