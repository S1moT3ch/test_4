using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lampeggio : MonoBehaviour
{
    public Material neonDx;
    public Material neonDxSpento;
    public GameObject luceDx;
    private bool onDx = false;
    public float lightDelay = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(AccendiDx());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AccendiDx()
    {
        while(true)
        {
            if(onDx)
            {
                luceDx.GetComponent<Renderer>().material = neonDxSpento;
                Debug.Log("Dx Off");
                onDx = false;

            }
            else
            {
                luceDx.GetComponent<Renderer>().material = neonDx;
                Debug.Log("Dx On");
                onDx = true;
            }
            yield return new WaitForSeconds(lightDelay);
        }
    }
}
