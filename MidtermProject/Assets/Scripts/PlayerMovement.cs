using UnityEngine;
using UnityEngine.SceneManagement;  

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  
    
    public float jumpForce = 7f;    
    
    private Rigidbody2D rb;    
    
    private bool isGrounded = true;  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        HandleMovement();  

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
            
        {
            Jump();
        }
    }

    void HandleMovement()
    {
        float move = Input.GetAxis("Horizontal");  
        
        
        
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);  
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 
        isGrounded = false;  
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block") || collision.gameObject.CompareTag("Ground"))
        {
            
            
            
            isGrounded = true;  
        }

        if (collision.gameObject.CompareTag("Block"))
        {
            Rigidbody2D blockRb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (blockRb != null && blockRb.velocity.y < -1f)  
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over! The player was hit by a falling block.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}