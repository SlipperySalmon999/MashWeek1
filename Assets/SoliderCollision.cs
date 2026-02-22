using UnityEngine;

public class SoliderCollision : MonoBehaviour
{
    public AudioClip SoliderSaved;
    private AudioSource audioSource;
    private float SolidersSaved;
    public SpawnEntities DaScript;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        GameObject goal = GameObject.Find("EndGoal");
        audioSource = goal.GetComponent<AudioSource>(); 
        SolidersSaved = DaScript.SolidersToSpawn;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            //subtract to the number soliders need to be saved
            SolidersSaved--;
            Debug.Log("Soldier has been sent to the hosiptal you aer a national hero now :)");
            audioSource.PlayOneShot(SoliderSaved);
            if (SolidersSaved <= 0)
            {
                Debug.Log("You're a weener");
                Application.LoadLevel("Win");
            }
            
          
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
