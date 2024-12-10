using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
 
public class CanvasHide : MonoBehaviour {
 
    public GameObject RoomMenu; // Assign in inspector
    public GameObject layout;
    public GameObject pause;
    private bool isShowing;

    public void Start()
    {

    }

    public void LetsPlay()
    {
        pause.SetActive(true);
        RoomMenu.SetActive(false);
        layout.SetActive(false);

    }
}