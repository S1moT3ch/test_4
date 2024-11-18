using UnityEngine;

public class NeonSx : MonoBehaviour
{
    public Material emissiveNeon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emissiveNeon.DisableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
