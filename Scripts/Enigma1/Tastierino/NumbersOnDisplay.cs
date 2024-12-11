using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumbersOnDisplay : MonoBehaviour
{
   
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static NumbersOnDisplay istance;

    public Light luceStanza1a;
    public Light luceStanza1b;
    public bool ResEn1 = false;

    [SerializeField] private AudioClip avviso;
    private AudioSource audioSource;

    void Awake()
    {
        istance=this;
    }

    void Start()
    {
       luceStanza1a.intensity = 0; //luce della stanza spenta
       luceStanza1b.intensity = 0;
       audioSource = GetComponent<AudioSource>(); //si ottiene la sorgente audio
    }

    void Update()
    {
        if(codice.Equals("96691")) //se sul tastierino è scritto 96691 si accende la luce
        {
            luceStanza1a.intensity = 2;
            luceStanza1b.intensity = 2;
            ResEn1 = true; //aggiornamento variabile per gestire apertura porta1
        }
    }

    public void UpdateCodice(string valore)
    {
        if(codice.Length == 5) //si cancellano i caratteri per non superare la grandezza del display
        {
            testo.text = reset;
            codice = reset + valore;
            testo.text = codice;
        }
        else //altrimenti si aggiorna il valore
        {
            codice = codice + valore;
            testo.text = codice;

            if(codice.Equals("96691")){  //se sul tastierino è scritto 96691 viene riprodotto l'audio
                audioSource.clip = avviso;
                audioSource.Play();
            }
        }
        
    }
}
