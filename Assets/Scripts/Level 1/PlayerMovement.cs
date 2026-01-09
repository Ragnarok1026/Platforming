using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private bool isFacingRight = true;
    public float runSpeed = 8f;
    public float JumpForce = 16f;
    private bool m_Grounded;
    public Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform m_CeilingCheck;


    private void Update()
    {
        // Update animator speed parameter based on horizontal movement
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        // Get horizontal input
        horizontal = Input.GetAxisRaw("Horizontal");
        // Handle jumping
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
        }
        // Handle variable jump height
        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
        // Handle crouching
        if (Input.GetButtonDown("Crouch") && IsGrounded())
        {
            transform.localScale = new Vector3(transform.localScale.x, 1.5f, transform.localScale.z);
        }
        // Handle standing up from crouch
        else if (Input.GetButtonUp("Crouch"))
        {
            transform.localScale = new Vector3(transform.localScale.x, 3f, transform.localScale.z);
        }
        // Flip character sprite based on movement direction
        Flip();
    }

    private void FixedUpdate()
    {
        // Apply horizontal movement
        rb.linearVelocity = new Vector2(horizontal * runSpeed, rb.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        // Check if the player is grounded using a circle overlap
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    private void Flip()
    {
        // Flip the character sprite when changing direction
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
