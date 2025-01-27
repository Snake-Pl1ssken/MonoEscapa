using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float gravity = -9.8f;

    [SerializeField] float verticalVelocity;

    CharacterController characterController;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();    
    }
    void Update()
    {
        Vector3 movementInput = Vector3.zero;
        
        //Movement onGround Player
        if (Input.GetKey(KeyCode.W))
        {
            movementInput.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementInput.z = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movementInput.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movementInput.x = -1;
        }
        //Movement onGround Player


        //Movement !onGround Player (Salto)
        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
            else
            { 
                verticalVelocity = 0;
            }
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }
        //Movement !onGround Player (Salto)


        Vector3 finalMovement = (movementInput.normalized * speed) + Vector3.up * verticalVelocity;   
        Move(finalMovement);
    }

    void Move(Vector3 direction)
    { 
        characterController.Move(direction * Time.deltaTime);
    }
}
