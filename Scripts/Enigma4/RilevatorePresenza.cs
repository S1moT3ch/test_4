using UnityEngine;
using System.Collections;

public class RilevatorePresenza : MonoBehaviour
{
    public bool consenso = false;

    public static RilevatorePresenza istance;

    void Awake()
    {
        istance=this;
    }
    
    public void OnTriggerEnter()
    {
        Debug.Log("Personaggio su rilevatore");
        consenso = true;
    }
}
