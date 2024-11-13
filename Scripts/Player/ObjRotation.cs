using UnityEngine;

public class ObjRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-110.0f, 120.0f, -20.0f, Space.Self);
    }
}
