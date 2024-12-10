using UnityEngine;

public class PickUpDKit : MonoBehaviour
{
    public GameObject DNAkit;
    public GameObject DNAkit2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DNAkit.SetActive(true);
        DNAkit2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (DKit.istance.clickOn)
        {
            DNAkit.SetActive(false);
            DKit.istance.clickOn = false;
        }
        if (DKit2.istance.clickOn)
        {
            DNAkit2.SetActive(false);
            DKit2.istance.clickOn = false;
        }
    }
}
