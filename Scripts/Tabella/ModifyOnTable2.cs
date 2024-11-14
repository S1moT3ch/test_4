using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModifyOnTable2 : MonoBehaviour
{
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static ModifyOnTable2 istance;

    void Awake()
    {
        istance=this;
    }

    public void UpdateCodiceTabella2(string valore)
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
