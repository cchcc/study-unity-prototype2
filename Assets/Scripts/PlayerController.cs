using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    // public float xRange = 15f;
    // public float zRange = 15f;

    public float leftBound = -10f;
    public float rightBound = 10f;
    public float topBound = 15f;
    public float bottomBound = 0f;
    
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (transform.position.x <= leftBound)
        {
            transform.position = new Vector3(
                leftBound,
                transform.position.y, 
                transform.position.z
                );
        }

        if (transform.position.x >= rightBound)
        {
            transform.position = new Vector3(
                rightBound,
                transform.position.y, 
                transform.position.z
            );
        }
        
        if (transform.position.z >= topBound)
        {
            transform.position = new Vector3(
                transform.position.x, 
                transform.position.y,
                    topBound
                );
        }
        
        if (transform.position.z <= bottomBound)
        {
            transform.position = new Vector3(
                transform.position.x, 
                transform.position.y,
                bottomBound
            );
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z +1f), projectilePrefab.transform.rotation);
        }
    }
}
