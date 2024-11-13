using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    private static GameObject _istance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (!_istance)
        {
            _istance = gameObject;
            DontDestroyOnLoad(gameObject);
        }
    }
}
