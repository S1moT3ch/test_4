using UnityEngine;

public class qP12 : MonoBehaviour
{
    public bool clickOn = false;
    public bool clickOnQ = false;
    public static qP12 istance;

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
        clickOnQ = true;
    }
}
