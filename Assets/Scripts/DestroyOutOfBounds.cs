using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBoundary =40;
    public float lowerBoundary =-20;
    public float leftBoundary =-40;
    public float rightBoundary =40;

    public GameObject gameManager;
    // private UpdateCounts _updateCounts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBoundary)
        {
            destroyGameObject();
        } else if (transform.position.x > rightBoundary)
        {
            destroyGameObject();
        } else if (transform.position.x < leftBoundary)
        {
            destroyGameObject();
        }

        void destroyGameObject()
        {
            gameManager.GetComponent<GameManager>().UpdateCounts("reduceLife");
            Destroy(gameObject);
        }
    }
}
