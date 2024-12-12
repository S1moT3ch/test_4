using UnityEngine;

public class MacchieView : MonoBehaviour
{
    public GameObject macchia1;
    public GameObject macchia2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        macchia1.SetActive(false);
        macchia2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerDnaKit.istance.isBlood1 == true && OnOffTorcia.istance.on == 2)
        {
            macchia1.SetActive(true);
        }
        else if (PlayerDnaKit.istance.isBlood1 == false && OnOffTorcia.istance.on != 2)
        {
            macchia1.SetActive(false);

            if (PlayerDnaKit.istance.isBlood2 && OnOffTorcia.istance.on == 2)
            {
                macchia2.SetActive(true);
            }
            else if (PlayerDnaKit.istance.isBlood2 == false && OnOffTorcia.istance.on != 2)
            {
                macchia2.SetActive(false);
            }
        }

        else if (PlayerDnaKit.istance.isBlood2 && OnOffTorcia.istance.on == 2)
        {
            macchia2.SetActive(true);
        }
        else if (PlayerDnaKit.istance.isBlood2 == false && OnOffTorcia.istance.on != 2)
        {
            macchia2.SetActive(false);

            if (PlayerDnaKit.istance.isBlood1 && OnOffTorcia.istance.on == 1)
            {
                macchia1.SetActive(true);
            }
            else if (PlayerDnaKit.istance.isBlood1 == false && OnOffTorcia.istance.on != 1)
            {
                macchia1.SetActive(false);
            }
        }
    }
}
