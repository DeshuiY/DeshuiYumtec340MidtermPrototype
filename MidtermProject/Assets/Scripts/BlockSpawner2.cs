using UnityEngine;

public class BlockSpawner2 : MonoBehaviour
{
    public GameObject blockPrefab;  
    public float spawnInterval = 2f;  

    private bool spawning = false;  

    void Start()
    {
        
    }

    public void StartSpawning()
    {
        if (!spawning)
        {
            spawning = true;
            InvokeRepeating("SpawnBlock", 0f, spawnInterval);  
        }
    }

    void SpawnBlock()
    {
        if (blockPrefab != null)
        {
           
            Instantiate(blockPrefab, transform.position, Quaternion.identity);
        }
    }
}