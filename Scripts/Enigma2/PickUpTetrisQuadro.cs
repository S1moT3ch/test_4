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
    public bool p1;
    public bool p2;
    public bool p3;
    public bool p4;
    public bool p5;
    public bool p6;
    public bool p7;
    public bool p8;
    public bool p9;
    public bool p10;
    public bool p11;
    public bool p12;
    public GameObject door2;
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
        if (p1 && p2 && p3 && p4 && p5 && p6 && p7 && p8 && p9 && p10 && p11 && p12) //se è stato risolto l'enigma 2
        {
            Destroy(door2); //apri la porta2
        }
        if (qP1.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 1) // se e solo se si clicca sul pezzo n del puzzle, viene mostrato il pezzo n sul quadro del tetris, inoltre si aggiorna la variabile pn per verificare il progresso nella soluzione dell'enigma e la variabile clickOnQ per effettuare ad ogni update il controllo sul pezzo clickato
        {
            qp1.SetActive(true);
            p1 = true;
            qP1.istance.clickOnQ = false;
        }
        else if (qP1.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 1)
        {
            qP1.istance.clickOnQ = false;
        }
        else if (qP2.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 2)
        {
            qp2.SetActive(true);
            p2 = true;
            qP2.istance.clickOnQ = false;
        }
        else if (qP2.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 2)
        {
            qP2.istance.clickOnQ = false;
        }
        else if (qP3.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 3)
        {
            qp3.SetActive(true);
            p3 = true;
            qP3.istance.clickOnQ = false;
        }
        else if (qP3.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 3)
        {
            qP2.istance.clickOnQ = false;
        }
        else if (qP4.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 4)
        {
            qp4.SetActive(true);
            p4 = true;
            qP4.istance.clickOnQ = false;
        }
        else if (qP4.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 4)
        {
            qP4.istance.clickOnQ = false;
        }
        else if (qP5.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 5)
        {
            qp5.SetActive(true);
            p5 = true;
            qP5.istance.clickOnQ = false;
        }
        else if (qP5.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 5)
        {
            qP5.istance.clickOnQ = false;
        }
        else if (qP6.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 6)
        {
            qp6.SetActive(true);
            p6 = true;
            qP6.istance.clickOnQ = false;
        }
        else if (qP6.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 6)
        {
            qP6.istance.clickOnQ = false;
        }
        else if (qP7.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 7)
        {
            qp7.SetActive(true);
            p7 = true;
            qP7.istance.clickOnQ = false;
        }
        else if (qP7.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 7)
        {
            qP7.istance.clickOnQ = false;
        }
        else if (qP8.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 8)
        {
            qp8.SetActive(true);
            p8 = true;
            qP8.istance.clickOnQ = false;
        }
        else if (qP8.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 8)
        {
            qP8.istance.clickOnQ = false;
        }
        else if (qP9.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 9)
        {
            qp9.SetActive(true);
            p9 = true;
            qP9.istance.clickOnQ = false;
        }
        else if (qP9.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 9)
        {
            qP9.istance.clickOnQ = false;
        }
        else if (qP10.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 10)
        {
            qp10.SetActive(true);
            p10 = true;
            qP10.istance.clickOnQ = false;
        }
        else if (qP10.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 10)
        {
            qP10.istance.clickOnQ = false;
        }
        else if (qP11.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 11)
        {
            qp11.SetActive(true);
            p11 = true;
            qP11.istance.clickOnQ = false;
        }
        else if (qP11.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 11)
        {
            qP11.istance.clickOnQ = false;
        }
        else if (qP12.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo == 12)
        {
            qp12.SetActive(true);
            p12 = true;
            qP12.istance.clickOnQ = false;
        }
        else if (qP12.istance.clickOnQ && PickUpTetrisPlayer.istance.pezzo != 12)
        {
            qP12.istance.clickOnQ = false;
        }
    }
}
