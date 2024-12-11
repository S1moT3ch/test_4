using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
 
public class CanvasHide : MonoBehaviour {
 
    public GameObject RoomMenu; 
    public GameObject layout;
    public GameObject pause;
    private bool isShowing;

    public void Start()
    {

    }

    public void LetsPlay() //quando viene chiamata questa funzione premendo un bottone nell'UI
    {
        pause.SetActive(true); //mostra il tasto pausa
        RoomMenu.SetActive(false); //nascondi la lobby
        layout.SetActive(false); //nascondi la schermata di start
    }
}