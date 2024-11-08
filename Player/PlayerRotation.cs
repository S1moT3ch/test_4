using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float sensX;
    public float sensY;


    float yRotation;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }
    
    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime *sensX;

        yRotation += mouseX;
        
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}