using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovements : MonoBehaviour
{
    private float speed;
    private Rigidbody rCube;
    private float wheelSpeed;

    // Start is called before the first frame update
    void Start()
    {
    rCube=gameObject.GetComponent<Rigidbody>();
    speed=5;
    wheelSpeed=3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            rCube.AddForce(new Vector3(speed,0,0),ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.A)){
            rCube.AddForce(new Vector3(-speed,0,0),ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.W)){
            rCube.AddForce(new Vector3(0,0,speed),ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.S)){
            rCube.AddForce(new Vector3(0,0,-speed),ForceMode.Force);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            rCube.AddForce(new Vector3(0,speed,0),ForceMode.Impulse);
        }
        {
    if(Input.GetKeyDown(KeyCode.L)){
            rCube.AddTorque(new Vector3(0,wheelSpeed,0),ForceMode.Impulse);
        }
    if(Input.GetKeyDown(KeyCode.K)){
            rCube.AddTorque(new Vector3(0,-wheelSpeed,0),ForceMode.Impulse);
        }
}
    }
}