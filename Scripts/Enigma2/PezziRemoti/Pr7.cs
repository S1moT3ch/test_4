using UnityEngine;

public class Pr7 : MonoBehaviour
{
    public bool clickOn = false;
    public bool clickOnT = false;
    public bool clickOnH = false;
    public static Pr7 istance;

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

    void OnMouseDown()
    {
        clickOn = true;
        clickOnT = true;
        clickOnH = true;
    }
}
