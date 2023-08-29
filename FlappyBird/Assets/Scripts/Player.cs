using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] public float gravity = -9.8f;
    [SerializeField] float strength = 5f;
    private bool isGameStarted = false; // Added variable to track game start

    private void Update()
    {
        if (!isGameStarted && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            StartGame();
        }

        if (isGameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                Jump();
            }

            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;
        }
    }

    private void StartGame()
    {
        isGameStarted = true;
        direction = Vector3.zero; // Reset the initial direction
        direction.y = strength;   // Apply initial jump
    }

    private void Jump()
    {
        direction.y = strength; // Apply jump force
    }
}
