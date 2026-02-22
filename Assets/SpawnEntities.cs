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
            GameObject SoliderCopy = Instantiate(Soliders, new Vector3(XPos, 0, ZPos), Quaternion.identity);
            SoliderCollision DaSolider = SoliderCopy.GetComponent<SoliderCollision>();
            DaSolider.DaScript = this;
        }
        
        solidersToSave = SolidersToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
