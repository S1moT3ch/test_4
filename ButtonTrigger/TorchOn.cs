using UnityEngine;

public class TorchOn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Light torcia;
    public bool on;
    public void Start()
    {
        on=false;
    }
    public void AccendiTorcia()
    {
        if (on == false)
        {
            torcia.intensity = 8;
            torcia.color = Color.magenta;
            on = true;
        }
        else
        {
            torcia.intensity = 0;
            on = false;
        }
    }
}
