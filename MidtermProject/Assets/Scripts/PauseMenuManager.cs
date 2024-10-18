using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    
    public Button resumeButton;  
    
    public Button restartButton; 
    
    public Button quitButton;     

    private bool isPaused = false;

    void Start()
    {
        
        resumeButton.onClick.AddListener(ResumeGame);
        
        
        restartButton.onClick.AddListener(RestartGame);
        
        
        quitButton.onClick.AddListener(QuitGame);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
                
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenuCanvas.SetActive(true);
        
        Time.timeScale = 0f;
        
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuCanvas.SetActive(false);
        
        Time.timeScale = 1f;
        
        isPaused = false;
    }

    public void RestartGame()
    
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game...");
        
        
        Application.Quit();
    }
}