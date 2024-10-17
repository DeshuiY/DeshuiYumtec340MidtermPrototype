using UnityEngine;
using UnityEngine.UI;

public class BeanCollector : MonoBehaviour
{
    public Text scoreText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bean"))
        {
            beansCollected++;
            Destroy(collision.gameObject);

            if (beansCollected == totalBeans)
            {
                float completionTime = Time.time - startTime;
                scoreText.text = "Time: " + completionTime.ToString("F2") + "s";
            }
        }
    }
}