using UnityEngine;

public class PickUpDKit : MonoBehaviour
{
    public GameObject DNAkit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DNAkit.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (DKit.istance.clickOn)
        {
            DNAkit.SetActive(false);
            DKit.istance.clickOn = false;
        }
        else if (DKit2.istance.clickOn)
        {
            DNAkit.SetActive(false);
            DKit.istance.clickOn = false;
        }
    }
}
