using UnityEngine;

public class SoliderCollision : MonoBehaviour
{
    public AudioClip SoliderSaved;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject goal = GameObject.Find("EndGoal");
        audioSource = goal.GetComponent<AudioSource>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Soldier has been sent to the hosiptal you aer a national hero now :)");
            audioSource.PlayOneShot(SoliderSaved);
            Destroy(gameObject);
            
    
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
