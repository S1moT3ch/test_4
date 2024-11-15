using UnityEngine;
public class FollowMouse : MonoBehaviour
{
    public float mouseSensitivity = 1000f;
    private float horizontalRotation=0;
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        horizontalRotation -= mouseX;
        horizontalRotation = Mathf.Clamp(horizontalRotation, -90f, 90f);
        transform.Rotate(Vector3.up*mouseX);
        transform.Rotate(Vector3.right*-mouseY);
    }
}