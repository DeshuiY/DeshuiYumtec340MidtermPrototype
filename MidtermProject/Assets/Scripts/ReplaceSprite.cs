using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReplaceSprite : MonoBehaviour
{
    public Sprite newSprite; 

    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}

