using UnityEngine;

public class PickUpTorciaPlayerDEF : MonoBehaviour
{
    public GameObject pTorcia;
    public bool isShowing = false;
    public static PickUpTorciaPlayerDEF istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pTorcia.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Torcia.istance.clickOn | Input.GetKeyDown(KeyCode.F12))
        {
            pTorcia.SetActive(!isShowing);
            isShowing = !isShowing;
            Torcia.istance.clickOn = false;
        }  
    }
}
