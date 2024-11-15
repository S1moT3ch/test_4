using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModifyOnTable15 : MonoBehaviour
{
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static ModifyOnTable15 istance;

    void Awake()
    {
        istance=this;
    }

    public void UpdateCodiceTabella15(string valore)
    {
        if(codice.Length == 1)
        {
            testo.text = reset;
            codice = reset + valore;
            testo.text = codice;
        }
        else
        {
            codice = codice + valore;
            testo.text = codice;
        }
        
    }
}
