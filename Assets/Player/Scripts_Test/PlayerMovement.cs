using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputActionReference Salto;
    [SerializeField] InputActionReference Caminar;
    [SerializeField] InputActionReference Correr;
    [SerializeField] InputActionReference Derecha;
    [SerializeField] InputActionReference Izquierda;
    [SerializeField] InputActionReference Atras;
    [SerializeField] InputActionReference GamePad;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float gravity = -9.8f;

    [SerializeField] float verticalVelocity;

    Rigidbody rigidoCuerpo; //No se esta usando

    CharacterController characterController;    
    //CONTROL PLAYERCAM

    //CONTROL PLAYERCAM

    void Awake()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        rigidoCuerpo = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }
    private void OnEnable()
    {
        Caminar.action.Enable();
        Correr.action.Enable();
        Salto.action.Enable();
        Derecha.action.Enable();
        Izquierda.action.Enable();
        Atras.action.Enable();
        GamePad.action.Enable();
    }
    private void OnDisable()
    {
        Caminar.action.Disable();
        Correr.action.Disable();
        Salto.action.Disable();
        Derecha.action.Disable();
        Izquierda.action.Disable();
        Atras.action.Disable();
        GamePad.action.Disable();
    }
    public void OnMove()
    { 
    
    }
    void Update()
    {
        Vector3 movementInput = Vector3.zero;
        Vector2 joystickInput = Vector2.zero;
        //Movement onGround Player KEYBOARD

        if (Caminar.action.IsPressed())
        {
            movementInput.z = 1;
        }
        else if (Atras.action.IsPressed())
        {
            movementInput.z = -1;
        }

        if (Derecha.action.IsPressed())
        {
            movementInput.x = 1;
        }
        else if (Izquierda.action.IsPressed())
        {
            movementInput.x = -1;
        }
        //Movement onGround Player GAMEPAD
        if (GamePad.action.WasPressedThisFrame())
        {
            joystickInput = GamePad.action.ReadValue<Vector2>();
        }
        Vector3 move = new Vector3(joystickInput.x, 0, joystickInput.y) * speed * Time.deltaTime;
        //Movement onGround Player


        //Movement !onGround Player (Salto)
        if (characterController.isGrounded)
        {
            if (Salto.action.WasPressedThisFrame())
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
