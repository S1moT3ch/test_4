using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumbersOnMonitor : MonoBehaviour
{
   
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;
    public string valoreb;

    public static NumbersOnMonitor istance;

    void Awake()
    {
        istance=this;
    }


    public void UpdateCodice(string valore)
    {
        if (PlayerMonitor.istance.isMonitor == true)
        {
            if (codice.Length == 23)
            {
                testo.text = reset;
                codice = reset + valore;
                valoreb = valore;
                testo.text = codice;
            }
            else
            {
                codice = codice + valore;
                valoreb = valore;
                testo.text = codice;
            }
        }
    }
    public void CancellaCarattere()
    {
        if (PlayerMonitor.istance.isMonitor == true)
        {
            if (codice.Length <= 0)
            {
                Debug.Log("Fine Striga");
            }
            else
            {
                codice = codice.Remove(codice.Length-1);
                testo.text = codice;
            }
        }
    }
}
