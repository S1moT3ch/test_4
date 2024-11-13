using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFail : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //DestroyImmediate(player, true);
        SceneManager.LoadScene(2);
    }
}
