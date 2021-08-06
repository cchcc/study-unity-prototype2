using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find(nameof(GameManager)).GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log($"collision object: {gameObject} - other: {other}");

        if (other.name.StartsWith("Food_Pizza_01"))
        {
            Destroy(gameObject);
            // Destroy(other.gameObject);
            // gameManager.AddScore(1);
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
        }


        if (other.name.StartsWith("Player"))
        {
            gameManager.AddLives(-1);
        }
    }
}