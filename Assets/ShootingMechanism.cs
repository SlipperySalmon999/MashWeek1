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
    
    public AudioSource audioSource;
    public AudioClip soliderLaunched;
    

    private void FirePlunger()
    {
        plungerCopy = Instantiate(plunger, FiringPoint.position, FiringPoint.rotation);
        Rigidbody rigidBodyPB = plungerCopy.GetComponent<Rigidbody>();
        rigidBodyPB.isKinematic = false;
        rigidBodyPB.AddForce(transform.forward * firePowah);
        rope.positionCount = 2;
        rope.enabled = true;
        
        PlungerCollision collisionScript = plungerCopy.GetComponent<PlungerCollision>();
        collisionScript.TheGunShip = this;
    }

    public void HideRope()
    {
        rope.enabled = false;
    }
    
    private void FireSolider()
    {
        GameObject soliderCopy = Instantiate(solider, FiringPoint.position, FiringPoint.rotation);
        Rigidbody rigidBodySold = soliderCopy.GetComponent<Rigidbody>(); 
        rigidBodySold.isKinematic = false;
        rigidBodySold.AddForce(transform.forward * firePowah);
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(soliderLaunched);
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
        }

        else if (Input.mouseScrollDelta.y < 0)
        {
            PlungerMode = false;
            SoliderMode = true;
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
