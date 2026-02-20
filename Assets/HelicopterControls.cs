using System;
using UnityEngine;

public class HelicopterControls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rigidBody;

    [SerializeField] private float Responsiveness;
    [SerializeField] private float Acceleration;

    private float Throttle;

    private float roll;
    private float pitch;
    private float yaw;

    private void HandleInputs()
    {
        roll = Input.GetAxis("Roll");
        pitch = Input.GetAxis("Pitch");
        yaw = Input.GetAxis("Yaw");

        if (Input.GetKey(KeyCode.Space))
        {
            Throttle += Time.deltaTime * Acceleration;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            Throttle -= Time.deltaTime * Acceleration;
        }
        else
        {
            Throttle -= Time.deltaTime * Acceleration;
        }
        

        Throttle = Mathf.Clamp(Throttle, 0.0f, 100f);
    }
    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame

    private void Update()
    {
        HandleInputs();
    }

    void FixedUpdate()
    {
        rigidBody.AddForce(transform.up * Throttle, ForceMode.Impulse);
        
        rigidBody.AddTorque(transform.right * pitch * Responsiveness);
        rigidBody.AddTorque(-transform.forward * roll * Responsiveness);
        rigidBody.AddTorque(transform.up * yaw * Responsiveness);
    }
}
