using UnityEngine;

public class OnOffTorcia : MonoBehaviour

{
    public Light torcia;
    public int on;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        torcia.intensity = 0;
        on = 0;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Mouse1)){
            AccendiTorcia();
         }
    }

    void AccendiTorcia()
    {
        if (on == 0)
        {
            torcia.intensity = 8;
            torcia.color = Color.white;
            on = 1;
        }
        else if (on == 1)
        {
            torcia.intensity = 8;
            torcia.color = Color.magenta;
            on = 2;
        }
        else if (on  ==2)
        {
            torcia.intensity = 0;
            on = 0;
        }
    }
}