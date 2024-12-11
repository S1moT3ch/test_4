using UnityEngine;

public class Door1Open : MonoBehaviour
{
    public GameObject door1;
    public GameObject door1a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NumbersOnDisplay.istance.ResEn1) //se l'enigma 1 è stato risolto
        {
            Destroy(door1);  //apri la porta1
            Destroy(door1a); //apri la porta1a
        }
    }
}
