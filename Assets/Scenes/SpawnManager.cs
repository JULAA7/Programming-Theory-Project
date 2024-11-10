using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] ovocePrefabs;

    private float spawnLimitZLeft = -10;
    private float spawnLimitZRight = 10;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;

    
    void Start()
    {
        InvokeRepeating("SpawnRandomOvoce", startDelay, spawnInterval);
    }

    
    void SpawnRandomOvoce ()
    {
        
        int ovoceIndex = Random.Range(0, ovocePrefabs.Length);
        Vector3 spawnPos = new Vector3(4, spawnPosY, Random.Range(spawnLimitZLeft, spawnLimitZRight));

        
        Instantiate(ovocePrefabs[ovoceIndex], spawnPos, ovocePrefabs[ovoceIndex].transform.rotation);
    }
    
}
