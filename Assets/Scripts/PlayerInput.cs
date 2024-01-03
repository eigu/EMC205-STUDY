using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput
{
    static public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    public Vector3 handleMovementInput()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 rawInput = new  Vector3(horizontalInput, verticalInput).normalized;

        return rawInput;
    }
}
