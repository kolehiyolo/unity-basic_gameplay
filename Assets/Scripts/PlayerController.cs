using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float horizontalIndex;

    public float xBounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalIndex = Input.GetAxis("Horizontal");

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
