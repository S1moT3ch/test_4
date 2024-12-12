using UnityEngine;

public class Tubo : MonoBehaviour
{
    public static Tubo istance;
    public bool apriT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        istance=this;
    }
    void Start()
    {
        apriT = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        apriT = true;
    }
}
