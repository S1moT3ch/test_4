using UnityEngine;

public class P6 : MonoBehaviour
{
    public bool clickOn = false;
    public static P6 istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        clickOn = true;
    }
}
