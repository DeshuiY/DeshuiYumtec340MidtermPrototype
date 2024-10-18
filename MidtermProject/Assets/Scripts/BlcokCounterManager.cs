using UnityEngine;
using UnityEngine.UI;

public class BlockCounterManager : MonoBehaviour
{
    public Text blockCounterText;
    public string blockTag = "Block";
    public Collider2D boundary;

    void Update()
    {
        if (blockCounterText != null && boundary != null)
        {
            UpdateBlockCount();
        }
    }

    void UpdateBlockCount()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag(blockTag);
        int blockCountInBoundary = 0;

        foreach (GameObject block in blocks)
        {
            if (boundary.bounds.Contains(block.transform.position))
            {
                blockCountInBoundary++;
            }
        }

        blockCounterText.text = "Blocks: " + blockCountInBoundary;
    }
}