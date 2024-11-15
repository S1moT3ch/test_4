using UnityEngine;

public class Bottone : MonoBehaviour
{
    public GameObject laser;

    private void OnMouseDown ()
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