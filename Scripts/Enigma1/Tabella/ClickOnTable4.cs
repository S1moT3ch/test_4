using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickOnTable4 : MonoBehaviour
{    
    public bool click = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0) && click)
        {
            ModifyOnTable4.istance.UpdateCodiceTabella4("0");
            click = false;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1) && click)
        {
            ModifyOnTable4.istance.UpdateCodiceTabella4("1");
            click = false;
        }
    }


    void OnMouseDown(){
        click = true;
        Debug.Log("Click");
    }
}

