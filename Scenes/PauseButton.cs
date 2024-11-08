using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
 
public class PauseButton : MonoBehaviour {
 
    public GameObject RoomMenu; // Assign in inspector
    public GameObject layout;
    public GameObject pauseStart;
    public EventSystem eventSystemPause;
    public EventSystem eventSystemPlay;
    private bool isShowing = false;

    public void Start()
    {
        pauseStart.SetActive(false);
    }
    public void LetsPause()
    {
        pauseStart.SetActive(false);
        RoomMenu.SetActive(true);
        layout.SetActive(true);
        eventSystemPause.enabled = false;
        eventSystemPlay.enabled = true;
        
        
    }
}