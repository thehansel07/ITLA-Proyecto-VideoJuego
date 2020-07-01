using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawner : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, .4f);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(){
        Instantiate(balloonPrefab, transform.position, transform.rotation);


    }

}
