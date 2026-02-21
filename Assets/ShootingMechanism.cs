using UnityEngine;

public class ShootingMechanism : MonoBehaviour
{
    public GameObject plunger;
    public Transform FiringPoint;
    private Rigidbody rigidBody;
    public float firePowah;
    private GameObject plungerCopy;
    
    public GameObject solider;
    private Rigidbody SoldrigidBody;
    private bool PlungerMode = true;
    private bool SoliderMode = false;

    public LineRenderer rope;
    

    private void FirePlunger()
    {
        Debug.Log("Da Plunger was fired");
        plungerCopy = Instantiate(plunger, FiringPoint.position, FiringPoint.rotation);
        Rigidbody rigidBodyPB = plungerCopy.GetComponent<Rigidbody>();
        rigidBodyPB.isKinematic = false;
        rigidBodyPB.AddForce(transform.forward * firePowah);
        rope.positionCount = 2;
        rope.enabled = true;
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
            FirePlunger();
        }
        else if (Input.GetMouseButtonDown(0) && SoliderMode)
        {
            FireSolider();
        }

        if (plungerCopy != null)
        {
            rope.SetPosition(0, FiringPoint.position);
            rope.SetPosition(1, plungerCopy.transform.position);
        }
    }
}
