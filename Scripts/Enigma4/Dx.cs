using UnityEngine;

public class Dx : MonoBehaviour
{
    public GameObject CubeP;
    private Rigidbody porta;
    public float intensity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        porta=CubeP.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (CubeP == null)
            {
                Debug.Log("Caveau già aperto");
            }
            else
            {
                porta.AddTorque(new Vector3(intensity,0,0),ForceMode.Impulse);
                CaveauManager.istance.UpdateDx(1);
            }
    }
}
