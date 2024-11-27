using UnityEngine;

public class DontDestroyChat : MonoBehaviour
{
    public GameObject canvasChat;
    public GameObject networkManager;
    public GameObject chatManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //DontDestroyOnLoad(canvasChat);
        //DontDestroyOnLoad(networkManager);
        DontDestroyOnLoad(chatManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
