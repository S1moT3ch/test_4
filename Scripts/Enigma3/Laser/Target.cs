using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public void Hit()
    {
        Debug.Log("Target Hit");
        SceneManager.LoadScene(2);
    }
}
