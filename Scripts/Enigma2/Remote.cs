using UnityEngine;

public class Remote : MonoBehaviour
{
    public static Remote istance;

    public string pezzoricevuto;
    public GameObject r3;
    public GameObject r6;
    public GameObject r7;
    public GameObject r10;
    public GameObject r11;
    public GameObject r12;

    void Start()
    {
        r3.SetActive(false);
        r6.SetActive(false);
        r7.SetActive(false);
        r10.SetActive(false);
        r11.SetActive(false);
        r12.SetActive(false);
    }
    void Awake()
    {
        istance=this;
    }
    public void Update()
    {
        if (pezzoricevuto.Equals("p3"))
        {
            r3.SetActive(true);
        }
        else if (pezzoricevuto.Equals("p6"))
        {
            r6.SetActive(true);
        }
        else if (pezzoricevuto.Equals("p7"))
        {
            r7.SetActive(true);
        }
        else if (pezzoricevuto.Equals("p10"))
        {
            r10.SetActive(true);
        }
        else if (pezzoricevuto.Equals("p11"))
        {
            r11.SetActive(true);
        }
        else if (pezzoricevuto.Equals("p12"))
        {
            r12.SetActive(true);
        }
    }
}
