using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2f;
    private float spawnInterval  = 1.5f;
    private const float spawnPosZ = 20f;
    private const float spawnRangeX = -20f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimals), startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimals()
    {
        var posX = Random.Range(-spawnRangeX, spawnRangeX);
        var animalPrefab = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
        Instantiate(animalPrefab, new Vector3(posX, 0f, spawnPosZ), animalPrefab.transform.rotation);
    }
}
