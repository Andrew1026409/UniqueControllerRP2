using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    public float lookSpeed = 3f; // Speed of looking left and right

    private Vector2 movementInput; // Input for movement
    private float lookInput; // Input for looking left and right

    void Update()
    {
        // Get movement input
        Vector3 movement = new Vector3(movementInput.x, 0.0f, movementInput.y);

        // Move the GameObject
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Get look input
        transform.Rotate(Vector3.up, lookInput * lookSpeed * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // Get movement input from flight stick
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        // Get look input from flight stick
        lookInput = context.ReadValue<float>();
    }

}

