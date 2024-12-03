using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        if(ChatView.istance.isShowing)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
        else
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            transform.position = cameraPosition.position;
        }
    }
}