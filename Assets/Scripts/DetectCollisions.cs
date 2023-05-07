using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.GetComponent<GameManager>().UpdateCounts("addToScore");

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
