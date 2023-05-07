using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spamDelay=3;
    public float durationBeforeDogIsAllowed =0;

    // Update is called once per frame
    void Update()
    {
        durationBeforeDogIsAllowed -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && durationBeforeDogIsAllowed <= 0)
        {
            durationBeforeDogIsAllowed = spamDelay;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
