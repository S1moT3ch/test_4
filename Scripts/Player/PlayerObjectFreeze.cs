using UnityEngine;

public class PlayerObjectFreeze : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerMonitor.istance.isMonitor)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
        else
        {
            Debug.Log("movimento");
            GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionX;
            GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionY;
            GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionZ;
        }
    }
}
