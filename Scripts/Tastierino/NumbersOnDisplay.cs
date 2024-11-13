using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumbersOnDisplay : MonoBehaviour
{
   
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static NumbersOnDisplay istance;

    public Light luceStanza1;

    //public AudioSource avviso;

    void Awake()
    {
        istance=this;
    }

    void Start()
    {
       luceStanza1.intensity = 0;
       //avviso.Play();
    }

    void Update()
    {
        if(codice.Equals("90091"))
        {
            luceStanza1.intensity = 2;
        }
    }

    public void UpdateCodice(string valore)
    {
        if(codice.Length == 5)
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
