using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Vector2 CameraPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        CameraPosition.x += Input.GetAxis("Mouse X");
        CameraPosition.y -= Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(CameraPosition.y, CameraPosition.x, 0.0f);
    }
}
