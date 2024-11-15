using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModifyOnTable9 : MonoBehaviour
{
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static ModifyOnTable9 istance;

    void Awake()
    {
        istance=this;
    }

    public void UpdateCodiceTabella9(string valore)
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
