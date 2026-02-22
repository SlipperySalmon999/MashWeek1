using UnityEngine;

public class SoliderCollision : MonoBehaviour
{
    public AudioClip SoliderSaved;
    
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Soldier has been sent to the hosiptal you aer a national hero now :)");
            Destroy(gameObject);
            
    
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
