using UnityEngine;

public class BlockSpawner3 : MonoBehaviour
{
    public GameObject blockPrefab;
    public float spawnInterval = 10f; 
    
    public float spawnXRange = 4f;

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