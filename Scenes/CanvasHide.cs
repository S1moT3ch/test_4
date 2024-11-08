using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
 
public class CanvasHide : MonoBehaviour {
 
    public GameObject RoomMenu; // Assign in inspector
    public GameObject layout;
    public GameObject pause;
    public EventSystem eventSystemPlay;
    public EventSystem eventSystemPause;
    private bool isShowing;

    public void LetsPlay()
    {
        pause.SetActive(true);
        //isShowing = !isShowing;
        RoomMenu.SetActive(false);
        layout.SetActive(false);
        eventSystemPlay.enabled = false;
        eventSystemPause.enabled = true;
    }
}