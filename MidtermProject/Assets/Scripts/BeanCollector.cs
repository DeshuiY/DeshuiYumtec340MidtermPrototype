using UnityEngine;

public class BeanCollector : MonoBehaviour
{
    public int beansCollected = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bean"))
        {
            beansCollected++;
            Destroy(collision.gameObject);
        }
    }
}