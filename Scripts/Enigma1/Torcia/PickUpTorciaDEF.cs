using UnityEngine;

public class PickUpTorciaDEF : MonoBehaviour
{
    public GameObject torcia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        torcia.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Torcia.istance.clickOn)
        {
            torcia.SetActive(false);
        }
    }
}
