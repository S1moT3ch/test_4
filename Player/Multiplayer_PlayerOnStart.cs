using UnityEngine;

public class Multiplayer_PlayerOnStart : MonoBehaviour
{
    private Alteruna.Avatar _avatar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _avatar = GetComponent<Alteruna.Avatar>();
        
        if (!_avatar.IsMe)
            return;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_avatar.IsMe)
            return;
    }
}
