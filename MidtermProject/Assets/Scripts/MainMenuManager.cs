using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuManager : MonoBehaviour
{
    public TMP_Text pressToPlayText;
  
    void Start()
    {
        StartCoroutine(BlinkText());
    }

    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
            
        {
            
            
            LoadGameScene();
        }
    }

    IEnumerator BlinkText()
    {
        while (true)
            
        {
            
            pressToPlayText.enabled = !pressToPlayText.enabled;
            
            
            yield return new WaitForSeconds(0.7f); 
        }
    }

    void LoadGameScene()
    {
        
        
        SceneManager.LoadScene("GameTutorialScene");
    }
}