using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    public float jumpForce = 7f;
    
    private Rigidbody2D rb;
    
    private bool isGrounded;

    void Start()
    
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            
            
            Jump();
        }
    }

    void Move()
    {
        float move = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        isGrounded = false;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            
            isGrounded = true;
        }
        
        if (collision.gameObject.CompareTag("Block") && collision.relativeVelocity.y > 0.1f)
        {
            Debug.Log("Game Over! You were crushed.");
            
        }
    }

    
    
}