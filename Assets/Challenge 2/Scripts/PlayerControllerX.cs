using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float lastSpawnedTime = 0f;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var time = Time.time;
            if (time - lastSpawnedTime > 2)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastSpawnedTime = time;
            }
        }
    }
}
