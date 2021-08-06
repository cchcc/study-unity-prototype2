using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2f;
    private float spawnInterval  = 1.5f;
    
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
        // top to bottom
        var animalPrefab1 = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
        Instantiate(animalPrefab1, new Vector3(Random.Range(-20f, 20f), 0f, 20f), animalPrefab1.transform.rotation);
        
        // left to right
        var animalPrefab2 = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
        Instantiate(animalPrefab2, new Vector3(-20f, 0f, Random.Range(0, 18f)), Quaternion.Euler(0f, 90f, 0f));
        
        // left to right
        var animalPrefab3 = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
        Instantiate(animalPrefab3, new Vector3(20f, 0f, Random.Range(0, 18f)), Quaternion.Euler(0f, -90f, 0f));
    }
    
}
