using UnityEngine;

public class ColliderMatt : MonoBehaviour
{
    public GameObject laser;
    public float passo = 3;

    private void OnTriggerEnter (Collider other)
    {
        if(laser == null)
        {
            Debug.Log("Already Win");
        }
        else
        {
        Debug.Log("Hit with Collider");
        laser.transform.position = laser.transform.position + new Vector3(0, 0, passo);
        }
    }
}
