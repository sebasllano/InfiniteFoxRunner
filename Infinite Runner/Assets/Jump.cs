using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

        public float jumpForce; 
        public float groundDistance = 0.2f;
        public LayerMask groundMask;
        public Animator animator;

    public bool isJumping;

        public Rigidbody2D rb2d;
        //private bool isGrounded;

        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        public void Click()
    {

        if (!isJumping)
        {
            animator.SetBool("Jump1", true);
            // Add upward force to make the character jump
            // rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            rb2d.AddForce(Vector2.up * jumpForce);
            isJumping = true;
            animator.SetBool("Saltando", true);
        }

    }
        void Update()
        {
            // Check if the character is on the ground
            //isGrounded = Physics2D.OverlapCircle(transform.position, groundDistance, groundMask);

            if ( !isJumping && Input.GetKeyDown(KeyCode.Space))
            {
            animator.SetBool("Jump1", true);
            // Add upward force to make the character jump
            // rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                rb2d.AddForce(Vector2.up * jumpForce);
                isJumping = true;
                animator.SetBool("Saltando", true);
            }
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isJumping = false;
            animator.SetBool("Saltando", false);
        }
    }
}
