using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    
    public void StartPlayButton()
    {
        SceneManager.LoadScene(2);
    }
}
