using UnityEngine;

public class ShootingMechanism : MonoBehaviour
{
    public GameObject plunger;
    public Transform FiringPoint;
    private Rigidbody rigidBody;
    public float firePowah;
    
    public GameObject solider;
    private Rigidbody SoldrigidBody;
    private bool PlungerMode = true;
    private bool SoliderMode = false;
    

    private void FirePlunger()
    {
        Debug.Log("Da Plunger was fired");
        GameObject plungerCopy = Instantiate(plunger, FiringPoint.position, FiringPoint.rotation);
        Rigidbody rigidBodyPB = plungerCopy.GetComponent<Rigidbody>();
        rigidBodyPB.isKinematic = false;
        rigidBodyPB.AddForce(transform.forward * firePowah);
    }
    
    private void FireSolider()
    {
        Debug.Log("Da Plunger was fired");
        GameObject soliderCopy = Instantiate(solider, FiringPoint.position, FiringPoint.rotation);
        Rigidbody rigidBodySold = soliderCopy.GetComponent<Rigidbody>(); 
        rigidBodySold.isKinematic = false;
        rigidBodySold.AddForce(transform.forward * firePowah);
    }


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            PlungerMode = true;
            SoliderMode = false;
            Debug.Log("PlungerMode!");
        }

        else if (Input.mouseScrollDelta.y < 0)
        {
            PlungerMode = false;
            SoliderMode = true;
            Debug.Log("SoliderMode!");
        }


        if (Input.GetMouseButtonDown(0) && PlungerMode)
        {
            plunger.SetActive(true);
            solider.SetActive(false);
            FirePlunger();
        }
        else if (Input.GetMouseButtonDown(0) && SoliderMode)
        {
            plunger.SetActive(false);
            solider.SetActive(true);
            FireSolider();
        }
    }
}
