using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public float xRange;
    public float zRange;
    public float animalXIndex;
    public float animalZIndex;
    public int spawnFrom;
    public float startDelay;
    public float spawnInterval;
    public float animalRotation;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        spawnFrom = Random.Range(0, 3);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        animalXIndex = Random.Range(-xRange, xRange);
        animalZIndex = Random.Range(-zRange, zRange);

        switch (spawnFrom)
        {
            case 0:
                Instantiate(animalPrefabs[animalIndex], new Vector3(animalXIndex, 0, 20), animalPrefabs[animalIndex].transform.rotation);
                break;
            case 1:
                // animalRotation = ;
                Instantiate(animalPrefabs[animalIndex], new Vector3(-40, 0, animalZIndex), Quaternion.Euler(new Vector3(0, 90, 0)));
                break;
            case 2:
                Instantiate(animalPrefabs[animalIndex], new Vector3(40, 0, animalZIndex), Quaternion.Euler(new Vector3(0, -90, 0)));
                break;
        }
    }
}
