using UnityEngine;

public class PickUpDKitPlayer : MonoBehaviour
{
    public GameObject pDNAKit;
    public GameObject pDNAKit2;

    public GameObject tampone;
    public GameObject tampone2;
    public bool isShowing = false;
    public static PickUpDKitPlayer istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pDNAKit.SetActive(false);
        tampone.SetActive(false);
        pDNAKit2.SetActive(false);
        tampone2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DKit.istance.clickOnP)
        {
            pDNAKit.SetActive(true);
            DKit.istance.clickOnP = false;
        }
        else if (DKit2.istance.clickOnP)
        {
            pDNAKit2.SetActive(true);
            DKit2.istance.clickOnP = false;
        }

        if (macchia1.istance.clickOnP)
        {
            tampone.SetActive(true);
        }
        if (macchia2.istance.clickOn)
        {
            tampone2.SetActive(true);
        }
        if (giraProvette.istance.clickOn)
        {
            if(pDNAKit.activeSelf && tampone.activeSelf)
            {
                pDNAKit.SetActive(false);
                tampone.SetActive(false);
                giraProvette.istance.clickOn = false;
                macchia1.istance.clickOnP = false;
            }
            else if (pDNAKit2.activeSelf && tampone.activeSelf)
            {
                pDNAKit2.SetActive(false);
                tampone2.SetActive(false);
                giraProvette.istance.clickOn = false;
                macchia2.istance.clickOnP = false;
            }
            
        }
    }
}
