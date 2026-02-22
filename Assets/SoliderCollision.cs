using UnityEngine;
using TMPro;

public class SoliderCollision : MonoBehaviour
{
    public AudioClip SoliderSaved;
    private AudioSource audioSource;
    public SpawnEntities DaScript;
    public UIScript OtherScript;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        GameObject goal = GameObject.Find("EndGoal");
        audioSource = goal.GetComponent<AudioSource>(); 
        GameObject plane = GameObject.Find("Plane");
        DaScript = plane.GetComponent<SpawnEntities>();
        GameObject camera =  GameObject.Find("Main Camera");
        OtherScript = camera.GetComponent<UIScript>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            //subtract to the number soliders need to be saved
            DaScript.SolidersToSpawn--;
            Debug.Log("Soldier has been sent to the hosiptal you aer a national hero now :) also " + DaScript.SolidersToSpawn + " left");
            audioSource.PlayOneShot(SoliderSaved);
            OtherScript.UpdateScoreSaved();
            if (DaScript.SolidersToSpawn <= 0)
            {
                Debug.Log("You're a weener");
                Application.LoadLevel("Win");
            }
            Destroy(gameObject);
          
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
