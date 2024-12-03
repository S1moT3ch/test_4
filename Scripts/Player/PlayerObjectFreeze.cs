using UnityEngine;

public class PlayerObjectFreeze : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerMonitor.istance.isMonitor | ChatView.istance.isShowing)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            GetComponent<Rigidbody>().freezeRotation = true;
        }
        else
        {
            Debug.Log("movimento");
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
