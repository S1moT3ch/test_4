using UnityEngine;

public class Remote : MonoBehaviour
{
    string pezzo;
    public void UpdateReceivedPiece(string msg)
    {
        pezzo = msg;
    }
}
