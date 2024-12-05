using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatMessage : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageText;

    public void SetText(string str)
    {
        if (str.Equals("p3") | str.Equals("p7"))
        {
            Debug.Log("messaggio di servizio");
        }
        else
        {
            messageText.text = str; 
        }
        
    }
}
