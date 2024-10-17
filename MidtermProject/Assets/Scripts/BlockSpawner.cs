using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    
    
    public float spawnInterval = 2f; 
    
    // Time between block spawns
    
    
    public float spawnXRange = 8f; 
    // Adjust based on screen size

    void Start()
    
    {
        
        InvokeRepeating("SpawnBlock", 1f, spawnInterval);
    }

    void SpawnBlock()
    
    {
        float randomX = Random.Range(-spawnXRange, spawnXRange);
        
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0f);
        
        Instantiate(blockPrefab, spawnPosition, Quaternion.identity);
    }
}