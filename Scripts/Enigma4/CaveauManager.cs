using UnityEngine;

public class CaveauManager : MonoBehaviour
{
    public static CaveauManager istance;
    public bool adx = false;
    public bool bsx = false;
    public bool cdx = false;
    public bool dsx = false;

    private int aadx = 0;
    private int basx = 0;
    private int cadx = 0;
    private int dasx = 0;
    private bool a = false;
    private bool b = false;
    private bool c = false;
    private bool d = false;

    public GameObject porta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        istance=this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aadx == 1)
            adx = true;
        else
            adx = false;

        if (cadx == 3)
            cdx = true;
        else
            cdx = false;

        if (basx == 2)
            bsx = true;
        else
            bsx = false;

        if (dasx ==1)
            dsx = true;
        else
            dsx = false;

        if (adx && bsx && cdx && dsx)
        {
            if (porta == null)
            {
                Debug.Log("Caveau già aperto");
            }
            else
            {
                Destroy(porta);
            }
        }

    }

    public void UpdateDx(int volte)
    {
        if (adx == false && bsx == false && cdx == false && dsx == false)
            {
            aadx = aadx + volte;
            Debug.Log("1 click prima volta a dx");
            }
        else if (adx  && bsx && cdx == false && dsx == false)
        {
            cadx = cadx + volte;
            Debug.Log("1 click terza volta a dx");
        }
        else if (adx  && bsx && cdx && dsx == false)
        {
            aadx = 0;
            adx = false;
            basx = 0;
            bsx = false;
            cadx = 0;
            cdx = false;
            Debug.Log("reset");
        }
    }

    public void UpdateSx(int volte)
    {
        if (adx && bsx == false && cdx == false && dsx == false)
        {
            basx = basx + volte;
            Debug.Log("1 click seconda volta a sx");
        }
        else if (adx && bsx && cdx == false && dsx == false)
        {
            aadx = 0;
            adx = false;
            basx = 0;
            bsx = false;
            Debug.Log("reset");
        }
        else if (adx && bsx && cdx && dsx == false)
        {
            dasx = dasx + volte;
            Debug.Log("1 click quarta volta a sx");
        }
    }
}
