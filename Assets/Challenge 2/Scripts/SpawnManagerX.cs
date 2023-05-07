using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public float startDelay = 1.0f;
    public float spawnInterval = 4.0f;
    public float spawnIntervalMin = 1.0f;
    public float spawnIntervalMax = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // spawnInterval = Random.Range(1.0f,5.0f);
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);

        Invoke("SpawnRandomBall", spawnInterval);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0, ballPrefabs.Length)], spawnPos, ballPrefabs[0].transform.rotation);
    }

}

