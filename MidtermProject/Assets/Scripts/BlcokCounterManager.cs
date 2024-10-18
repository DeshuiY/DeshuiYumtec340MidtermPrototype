using UnityEngine;
using TMPro;

public class BlockCounterManager : MonoBehaviour
{
    public TMP_Text blockCounterText; 
    
    public TMP_Text timerText;         

    private int blockCount = 0;
    
    private float timeRemaining = 60f;  
    
    private bool timerIsRunning = true;

    void Start()
    {
        if (blockCounterText == null || timerText == null)
            
        {
            
            
            Debug.LogError("UI Text is not assigned in the Inspector!");
            return;
        }
        

        UpdateBlockCountUI();
        UpdateTimerUI();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
                
            {
                
                
                
                timeRemaining -= Time.deltaTime;
                UpdateTimerUI();
            }
            
            else
            
            {
                timeRemaining = 0;
                timerIsRunning = false;
                TimerEnded();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Block"))
            
        {
            
            blockCount++;
            
            UpdateBlockCountUI();
        }
    }

    void UpdateBlockCountUI()
    
    {
        
        
        blockCounterText.text = "Blocks: " + blockCount;
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
            
        {
            
            int minutes = Mathf.FloorToInt(timeRemaining / 60);
            
            int seconds = Mathf.FloorToInt(timeRemaining % 60);
            
            timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
        }
    }

    void TimerEnded()
    
    {
        
        Debug.Log("Timer Ended! Game Over.");
        
    }
}