using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private float wheelSpeed;
    private Rigidbody wheel;

    // Start is called before the first frame update
    void Start()
    {
    wheel=gameObject.GetComponent<Rigidbody>();
    wheelSpeed=5;
    }
private void Update()
{
    if(Input.GetKey(KeyCode.K)){
            wheel.AddTorque(new Vector3(0,0,wheelSpeed),ForceMode.Force);
        }
    if(Input.GetKey(KeyCode.L)){
            wheel.AddTorque(new Vector3(0,0,-wheelSpeed),ForceMode.Force);
        }
}
}