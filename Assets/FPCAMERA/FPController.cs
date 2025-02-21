using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPController : MonoBehaviour
{
    [SerializeField] private float sens;
    private Vector2 mouseInput;
    private float pitch;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.up, mouseInput.x * sens * Time.deltaTime);
        pitch = Mathf.Clamp(pitch,-90f,90f);
        transform.localEulerAngles = new Vector3(pitch,transform.localEulerAngles.y,0f);
    }
    public void onMouseMove(InputAction.CallbackContext context)
    { 
    
    }
}
