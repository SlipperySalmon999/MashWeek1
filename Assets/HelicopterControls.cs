using System;
using UnityEngine;

public class HelicopterControls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rigidBody;

    [SerializeField] private float Acceleration;
    [SerializeField] private float Thrust;
    [SerializeField] public float maxHeight;

    private float Throttle;

   // private float roll;
   // private float pitch;
   // private float yaw;

    private void HandleInputs()
    {
        //roll = Input.GetAxis("Roll");
        //pitch = Input.GetAxis("Pitch");
        //yaw = Input.GetAxis("Yaw");

        if (Input.GetKey(KeyCode.Space))
        {
            Throttle += Time.deltaTime * Thrust;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            Throttle -= Time.deltaTime * Thrust;
        }
        else
        {
            Throttle -= Time.deltaTime * Thrust;
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
        
        if (Input.GetKey(KeyCode.W))
            rigidBody.AddForce(transform.forward * Acceleration, ForceMode.Force);

        if (Input.GetKey(KeyCode.S))
            rigidBody.AddForce(-transform.forward * Acceleration, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            rigidBody.AddForce(-transform.right * Acceleration, ForceMode.Force);

        if (Input.GetKey(KeyCode.D))
            rigidBody.AddForce(transform.right * Acceleration, ForceMode.Force);
        

        if (transform.position.y >= maxHeight)
        {
            // Clamp height
            Vector3 pos = transform.position;
            pos.y = maxHeight;
            transform.position = pos;

            // Remove vertical velocity completely
            rigidBody.linearVelocity = new Vector3(
                rigidBody.linearVelocity.x,
                0f,
                rigidBody.linearVelocity.z
            );
        }
        
        /*
        rigidBody.AddTorque(transform.right * pitch * Responsiveness);
        //rigidBody.AddTorque(-transform.forward * roll * Responsiveness);
        rigidBody.AddTorque(transform.up * yaw * Responsiveness);
        */
    }
}
