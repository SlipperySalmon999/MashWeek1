using UnityEngine;

public class ShootingMechanism : MonoBehaviour
{
    public GameObject plunger;
    public Transform FiringPoint;
    private Rigidbody rigidBody;

    private void FirePlunger()
    {
        Debug.Log("Da Plunger was fired");
        GameObject plungerCopy = Instantiate(plunger, FiringPoint.position, Quaternion.identity);
        rigidBody = plungerCopy.GetComponent<Rigidbody>(); 
        rigidBody.AddForce(transform.forward * 500.0f);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            FirePlunger();
        }
    }
}
