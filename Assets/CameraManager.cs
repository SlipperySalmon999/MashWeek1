using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCam;
    public Camera FPCam;

    private void SwitchMaincam()
    {
        mainCam.enabled = true;
        FPCam.enabled = false;
    }

    private void SwitchFPCam()
    {
        mainCam.enabled = false;
        FPCam.enabled = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        mainCam.enabled = true;
        FPCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2)) 
        {
            Debug.Log("Right mouse button pressed!");
            if (mainCam.enabled)
                SwitchFPCam();
            else
                SwitchMaincam();
        }
    }
}
