using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives = 3;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        // lives = maxLives;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCounts(string type)
    {
        switch (type)
        {
            case "addToScore":
                score++;
                Debug.Log("Score: " + score);
                break;
            case "reduceLife":
                lives--;
                score = 0;

                Debug.Log("Lives: " + lives);

                if (lives <= 0)
                {
                    Debug.Log("Game Over");
                }
                break;
        }
    }
}
