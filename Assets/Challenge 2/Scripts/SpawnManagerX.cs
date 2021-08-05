using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay);
        // InvokeRepeating(nameof(SpawnRandomBall), startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        var ballPrefab = ballPrefabs[Random.Range(0, ballPrefabs.Length)];
        var spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);
        
        Invoke(nameof(SpawnRandomBall), Random.Range(3, 5));
    }

}
