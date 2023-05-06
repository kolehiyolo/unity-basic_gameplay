using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public float xRange;
    public float animalXIndex;
    public float startDelay;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        animalXIndex = Random.Range(-xRange, xRange);

        Instantiate(animalPrefabs[animalIndex], new Vector3(animalXIndex, 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}
