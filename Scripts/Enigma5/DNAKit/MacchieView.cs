using UnityEngine;

public class MacchieView : MonoBehaviour
{
    public bool m1;
    public bool m2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update() //se il player sta guardando la macchia n ed è accesa la torcia sul colore UV, aggiorna la relativa variabile per la corrispondente macchia di sangue, altrimenti mantieni falsa la variabile
    {        
        if (PlayerDnaKit.istance.isBlood1 == true && OnOffTorcia.istance.on == 2)
        {
            MacchieHide.istance.m1 = true;
        }
        else if (PlayerDnaKit.istance.isBlood1 == false && OnOffTorcia.istance.on != 2)
        {
            MacchieHide.istance.m1 = false;

            if (PlayerDnaKit.istance.isBlood2 && OnOffTorcia.istance.on == 2)
            {
                MacchieHide.istance.m2 = true;
            }
            else if (PlayerDnaKit.istance.isBlood2 == false && OnOffTorcia.istance.on != 2)
            {
                MacchieHide.istance.m2 = false;
            }
        }

        else if (PlayerDnaKit.istance.isBlood2 && OnOffTorcia.istance.on == 2)
        {
           MacchieHide.istance.m2 = true;
        }
        else if (PlayerDnaKit.istance.isBlood2 == false && OnOffTorcia.istance.on != 2)
        {
            MacchieHide.istance.m2 = false;

            if (PlayerDnaKit.istance.isBlood1 && OnOffTorcia.istance.on == 1)
            {
                MacchieHide.istance.m1 = true;
            }
            else if (PlayerDnaKit.istance.isBlood1 == false && OnOffTorcia.istance.on != 2)
            {
                MacchieHide.istance.m1 = false;
            }
        }
    }
}
