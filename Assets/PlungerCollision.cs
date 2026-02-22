using UnityEngine;

public class PlungerCollision : MonoBehaviour
{
    public AudioClip SoliderHit;
    public ShootingMechanism TheGunShip;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Soldier"))
        {
            TheGunShip.SolidersBeingHeld++;
            Debug.Log("Soldier has been hit");
            TheGunShip.audioSource.PlayOneShot(SoliderHit);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            TheGunShip.HideRope();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
