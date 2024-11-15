using UnityEngine;

public class UltimaMattonella : MonoBehaviour
{
    public GameObject laser;

    private void OnTriggerEnter (Collider other)
    {
        if(laser == null)
        {
            Debug.Log("Already Win");
        }
        else
        {
        Debug.Log("Win");
        Destroy(laser);
        }
    }
}