using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    public string nextSceneName;  
    public float requiredHeight = 1f;  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            if (other.transform.position.y >= requiredHeight)
            {
                LoadNextScene();
            }
            else
            {
                Debug.Log("Height too low. Cannot enter the door.");
            }
        }
    }

    void LoadNextScene()
    {
        Debug.Log("Loading next scene...");
        SceneManager.LoadScene(nextSceneName);
    }
}