using UnityEngine;

public class PlungerCollision : MonoBehaviour
{
    
    public AudioClip SoliderHit;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Soldier"))
        {
            Debug.Log("Soldier has been hit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
