using UnityEngine;

public class NeonSx : MonoBehaviour
{
    public Light neonSx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        neonSx.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        neonSx.intensity = 0;
        neonSx.intensity = 8;
        neonSx.intensity = 0;
        neonSx.intensity = 8;
        neonSx.intensity = 0;
        neonSx.intensity = 0;
        neonSx.intensity = 0;
        neonSx.intensity = 0;
        neonSx.intensity = 0;
        neonSx.intensity = 8;
        neonSx.intensity = 0;
    }
}
