using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovement : MonoBehaviour
{
    [HideInInspector] public bool isPenguinJumping = false;

    private Rigidbody2D rigidBody2D;
    private BoxCollider2D boxColl2D;
    private Animator anim;
    [SerializeField] private LayerMask jumpableGround;

    [Range(1,10)]
    public float jumpVelocity;

    private void Awake()
    {
        rigidBody2D = transform.GetComponent<Rigidbody2D>();
        boxColl2D = transform.GetComponent<BoxCollider2D>();
        anim = this.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidBody2D.velocity = Vector2.up * jumpVelocity;
            isPenguinJumping = true;
        }
        else if (IsGrounded()==false && rigidBody2D.velocity.y>0)
        {
            anim.SetBool("IsLaunching", true);
            isPenguinJumping = true;
        }
        else if (IsGrounded() == false && rigidBody2D.velocity.y < 7)
        {
            anim.SetBool("IsLaunching", false);
            anim.SetBool("IsFalling", true);
            isPenguinJumping = true;
        }
        else if (IsGrounded() == true)
        {
            anim.SetBool("JumpEnded", true);
            anim.SetBool("IsFalling", false);
            isPenguinJumping = false;
        }
        
    }

    public bool IsGrounded()
    {
        return Physics2D.BoxCast(boxColl2D.bounds.center, boxColl2D.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

}
