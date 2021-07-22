using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float mousesensitivity=1f;
    public Transform playerbody;
    float xRotation = 0f;
    // Update is called once per frame
    void start()
    {
        Cursor.lockState= CursorLockMode.Locked;
    }
    void Update()
    {
        
        float mousex = Input.GetAxis("Mouse X")*mousesensitivity*Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y")*mousesensitivity*Time.deltaTime;
        
        xRotation-=mousey;
        xRotation=Mathf.Clamp(xRotation,-90f,90f);

        transform.localRotation  = Quaternion.Euler(xRotation, 0f,0f);
        playerbody.Rotate(Vector3.up*mousex);
    }
}
