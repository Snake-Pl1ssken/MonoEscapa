using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlFP : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Transform cameraTransform;
    private Rigidbody rigidocuerpo;
    private Vector2 moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rigidocuerpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 move = cameraTransform.forward*moveInput.y + cameraTransform.right * moveInput.x;
        move.y = 0f;
        rigidocuerpo.AddForce(move.normalized * speed, ForceMode.VelocityChange);
    }
    public void OnMove(InputAction.CallbackContext context)
    { 
    moveInput = context.ReadValue<Vector2>();
    }
}
