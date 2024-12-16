using UnityEngine;

public class MacchieHide : MonoBehaviour
{
    public GameObject macchia1;
    public GameObject macchia2;
    public bool m1;
    public bool m2;
    public static MacchieHide istance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        macchia1.SetActive(false);
        macchia2.SetActive(false);
        m1 = false;
        m2 = false;
    }

    void Awake()
    {
        istance=this;
    }

    // Update is called once per frame
    void Update() //se il player sta guardando la macchia n ed è accesa la torcia sul colore UV, leggi il valore della relativa variabile ed eventualmente mostra la corrispondente macchia di sangue, altrimenti non mostrarla
    {        
        if (m1)
        {
            macchia1.SetActive(true);
        }
        else if (m1 = false)
        {
            macchia1.SetActive(false);

            if (m2 = true)
            {
                macchia2.SetActive(true);
            }
            else if (m2 = false)
            {
                macchia2.SetActive(false);
            }
        }

        else if (m2 = true)
        {
            macchia2.SetActive(true);
        }
        else if (m2 = false)
        {
            macchia2.SetActive(false);

            if (m1 = true)
            {
                macchia1.SetActive(true);
            }
            else if (m1 = false)
            {
                macchia1.SetActive(false);
            }
        }
    }
}
