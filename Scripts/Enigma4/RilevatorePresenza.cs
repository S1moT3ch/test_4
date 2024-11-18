using UnityEngine;

public class RilevatorePresenza : MonoBehaviour
{
    public Material neonSx;
    public Material neonDx;
    
    public void OnTriggerEnter()
    {
        Debug.Log("Personaggio su rilevatore");
        neonDx.EnableKeyword("_EMISSION");
        new WaitForSeconds(1);
        Debug.Log("Dx acceso");
        neonDx.DisableKeyword("_EMISSION");
        
        //neonSx.EnableKeyword("_EMISSION");
        //neonSx.DisableKeyword("_EMISSION");
        //neonDx.EnableKeyword("_EMISSION");
        //neonDx.DisableKeyword("_EMISSION");
        //neonDx.EnableKeyword("_EMISSION");
        //neonDx.DisableKeyword("_EMISSION");
        //neonDx.EnableKeyword("_EMISSION");
        //neonDx.DisableKeyword("_EMISSION");
        //neonSx.EnableKeyword("_EMISSION");
        //neonSx.DisableKeyword("_EMISSION");
    }
}
