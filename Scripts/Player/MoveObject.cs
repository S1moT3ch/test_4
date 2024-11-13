using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform objPos;

    private void Update()
    {
        transform.position = objPos.position;
    }
}