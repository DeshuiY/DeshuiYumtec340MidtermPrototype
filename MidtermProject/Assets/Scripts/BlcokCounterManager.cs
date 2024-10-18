using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class BlockCounterManager : MonoBehaviour
{
    public TMP_Text blockCounterText;
    public string blockTag = "Block";
    public Collider2D boundary;

    private int blockCount = 0;

    void Update()
    {
        blockCounterText.text = "Blocks: " + blockCount;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(blockTag))
        {
            blockCount++;
            UpdateBlockCountUI();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(blockTag) && blockCount > 0)
        {
            blockCount--;
            UpdateBlockCountUI();
        }
    }

    void UpdateBlockCountUI()
    {
        blockCounterText.text = "Blocks: " + blockCount;
    }
}