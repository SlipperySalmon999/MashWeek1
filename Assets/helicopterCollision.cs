using UnityEngine;
public class helicopterCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            Debug.Log("You losah you hit a tree good one");
            Application.LoadLevel("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
