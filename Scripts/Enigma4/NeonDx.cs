using UnityEngine;

public class NeonDx : MonoBehaviour
{
    public Light neonDx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        neonDx.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        neonDx.intensity = 8;
        neonDx.intensity = 0;
        neonDx.intensity = 0;
        neonDx.intensity = 0;
        neonDx.intensity = 0;
        neonDx.intensity = 8;
        neonDx.intensity = 0;
        neonDx.intensity = 8;
        neonDx.intensity = 0;
        neonDx.intensity = 8;
        neonDx.intensity = 0;
    }  
}
