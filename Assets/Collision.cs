using UnityEngine;

public class Collision : MonoBehaviour
{

    public AudioClip SoliderHit;

    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Solider"))
        {
            Debug.Log("Solider has been hit");
            audioSource.PlayOneShot(SoliderHit);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
