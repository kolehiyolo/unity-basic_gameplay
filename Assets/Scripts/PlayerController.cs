using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalIndex;
    public float xRange;
    public float speed;

    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalIndex = Input.GetAxis("Horizontal");

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Debug.Log("Launch a projectile from the player");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        if (
            (transform.position.x < xRange && transform.position.x > (-xRange))
            || (transform.position.x > xRange && horizontalIndex < 0)
            || (transform.position.x < (-xRange) && horizontalIndex > 0)
        )
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalIndex);
        }
    }
}
