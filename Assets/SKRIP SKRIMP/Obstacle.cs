// more code that mives the stuff forwards 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Jimmy").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)

        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
