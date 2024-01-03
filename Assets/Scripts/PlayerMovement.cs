using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerInput playerInput;
    public float movementSpeed = 5f;

    void Update()
    {
        handleMovement(playerInput.handleMovementInput());
    }

    public void handleMovement(Vector3 rawInput)
    {
        playerInput.player.transform.Translate(rawInput * movementSpeed * Time.deltaTime);
    }
}
