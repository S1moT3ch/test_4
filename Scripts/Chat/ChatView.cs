using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChatView : MonoBehaviour
{
    public bool isShowing = false;
    public GameObject canvasChat;
    public static ChatView istance;
    
    public void Start()
    {
        canvasChat.SetActive(false);
    }

    void Awake()
    {
        istance=this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            canvasChat.SetActive(!isShowing);
            isShowing = !isShowing;
        }
    }
}
