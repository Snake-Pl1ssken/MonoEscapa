using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TerceraPersonaCam : MonoBehaviour
{
    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public Rigidbody rb;
    public CharacterController characterController;
    public float rotationSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    public void Update()
    {
        Vector3 viewDirection = player.position - new Vector3(transform.position.x,player.position.y,transform.position.z);
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;
        if (inputDir != Vector3.zero)
        {
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }
        //transform.rotation = Quaternion.Euler();
    }
}
