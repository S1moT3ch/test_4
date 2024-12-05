using UnityEngine;

public class Remote : MonoBehaviour
{
    public static Remote istance;

    public string pezzoricevuto;
    public GameObject r3;
    private Rigidbody rb3;
    public GameObject r7;
    private Rigidbody rb7;
    

    void Start()
    {
        rb3=r3.GetComponent<Rigidbody>();
        rb7=r7.GetComponent<Rigidbody>();
        
        r3.SetActive(false);
        r7.SetActive(false);
    

        rb3.useGravity = false;
        rb7.useGravity = false;
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
            rb3.useGravity = true;
        }
        else if (pezzoricevuto.Equals("p7"))
        {
            r7.SetActive(true);
            rb7.useGravity = true;
        }
    }
}
