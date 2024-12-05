using UnityEngine;

public class MovimentoF : MonoBehaviour
{
    public GameObject foglio;
    public float passo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        foglio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (giraProvette.istance.clickOn)
        {
            foglio.SetActive(true);
        }
        
    }
}
