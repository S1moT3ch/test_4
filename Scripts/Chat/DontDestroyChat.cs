using UnityEngine;

public class DontDestroyChat : MonoBehaviour
{
    public GameObject _istanceC;
    public GameObject _istanceM;
    public GameObject _istanceCM;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() //se le istanze relative alla finestra della chat, al Network Manager e al Chat Manager sono disattivate, non distruggere i relativi GameObject nel passaggio fra le scene
    {
        if(!_istanceC)
        {
            _istanceC = gameObject;
            DontDestroyOnLoad(gameObject);
        }

        if(!_istanceM)
        {
            _istanceM = gameObject;
            DontDestroyOnLoad(gameObject);
        }

        if(!_istanceCM)
        {
            _istanceCM = gameObject;
            DontDestroyOnLoad(gameObject);
        }
    }
}
