using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiRotator : MonoBehaviour
{
    public GameObject TextName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextName != null)
        { 
            TextName.transform.LookAt(Camera.main.transform.position);
            TextName.transform.Rotate(0, 180, 0);
        } 
    }
}
