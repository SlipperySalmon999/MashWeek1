using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpawnEntities DaScript;
    private int PickedUp;
    private int Saved;
    public TMP_Text soldiersSavedText;
    public TMP_Text soldiersPickedUpText;
    public PlungerCollision plungerCollision;
    void Start()
    {
        GameObject plane = GameObject.Find("Plane");
        DaScript = plane.GetComponent<SpawnEntities>();
        Saved = 0;
        PickedUp = 0;
    }

    public void UpdateScorePickUp()
    {
        PickedUp++;
        soldiersPickedUpText.text = "Picked Up: " +  PickedUp;
    }
    
    public void UpdateScoreSaved()
    {
        Saved++;
        soldiersSavedText.text = "Soldiers Saved: " + Saved;
    }

    public void DecrementSolider()
    {
        PickedUp--;
        soldiersPickedUpText.text = "Picked Up: " +  PickedUp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
