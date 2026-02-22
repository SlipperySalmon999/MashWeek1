using UnityEngine;

public class PlungerCollision : MonoBehaviour
{
    public AudioClip SoliderHit;
    public ShootingMechanism TheGunShip;
    public int SoldiersPickedUp;
    public UIScript OtherScript;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject camera =  GameObject.Find("Main Camera");
        OtherScript = camera.GetComponent<UIScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Soldier"))
        {
            OtherScript.UpdateScorePickUp();
            SoldiersPickedUp++;
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
