using UnityEngine;

public class SpawnEntities : MonoBehaviour
{
    public GameObject Trees;

    public GameObject Soliders;

    public int TreesToSpawn;

    public int SolidersToSpawn;

    private int solidersToSave;

    private float XPos;

    private float ZPos;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        for (int i = 0; i < TreesToSpawn; i++)
        {
            XPos = Random.Range(-100, 100);
            ZPos = Random.Range(-100, 100);
            Instantiate(Trees, new Vector3(XPos, 0, ZPos), Quaternion.identity);
        }
        
        for (int i = 0; i < SolidersToSpawn; i++)
        {
            XPos = Random.Range(-100, 100);
            ZPos = Random.Range(-100, 100);
            Instantiate(Soliders, new Vector3(XPos, 0, ZPos), Quaternion.identity);
        }
        
        solidersToSave = SolidersToSpawn;
    }

    public void DaWinCondition()
    {
        solidersToSave--;
        if (solidersToSave <= 0)
        {
            Debug.Log("You're a weener");
            Application.LoadLevel("Win");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
