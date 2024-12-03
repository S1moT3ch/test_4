using UnityEngine;

public class PickUpTetrisQuadro : MonoBehaviour
{
    public GameObject qp1;
    public GameObject qp2;
    public GameObject qp3;
    public GameObject qp4;
    public GameObject qp5;
    public GameObject qp6;
    public GameObject qp7;
    public GameObject qp8;
    public GameObject qp9;
    public GameObject qp10;
    public GameObject qp11;
    public GameObject qp12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        qp1.SetActive(false);
        qp2.SetActive(false);
        qp3.SetActive(false);
        qp4.SetActive(false);
        qp5.SetActive(false);
        qp6.SetActive(false);
        qp7.SetActive(false);
        qp8.SetActive(false);
        qp9.SetActive(false);
        qp10.SetActive(false);
        qp11.SetActive(false);
        qp12.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (qP1.istance.clickOnQ)
        {
            qp1.SetActive(true);
            qP1.istance.clickOnQ = false;
        }
        else if (qP2.istance.clickOnQ)
        {
            qp2.SetActive(true);
            qP2.istance.clickOnQ = false;
        }
        else if (qP3.istance.clickOnQ)
        {
            qp3.SetActive(true);
            qP3.istance.clickOnQ = false;
        }
        else if (qP4.istance.clickOnQ)
        {
            qp4.SetActive(true);
            qP4.istance.clickOnQ = false;
        }
        else if (qP5.istance.clickOnQ)
        {
            qp5.SetActive(true);
            qP5.istance.clickOnQ = false;
        }
        else if (qP6.istance.clickOnQ)
        {
            qp6.SetActive(true);
            qP6.istance.clickOnQ = false;
        }
        else if (qP7.istance.clickOnQ)
        {
            qp7.SetActive(true);
            qP7.istance.clickOnQ = false;
        }
        else if (qP8.istance.clickOnQ)
        {
            qp8.SetActive(true);
            qP8.istance.clickOnQ = false;
        }
        else if (qP9.istance.clickOnQ)
        {
            qp9.SetActive(true);
            qP9.istance.clickOnQ = false;
        }
        else if (qP10.istance.clickOnQ)
        {
            qp10.SetActive(true);
            qP10.istance.clickOnQ = false;
        }
        else if (qP11.istance.clickOnQ)
        {
            qp11.SetActive(true);
            qP11.istance.clickOnQ = false;
        }
        else if (qP12.istance.clickOnQ)
        {
            qp12.SetActive(true);
            qP12.istance.clickOnQ = false;
        }
    }
}
