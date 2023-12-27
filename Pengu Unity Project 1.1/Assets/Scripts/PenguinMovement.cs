using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovement : MonoBehaviour
{
    [HideInInspector] public bool isPenguinJumping = false, isWalking=true;

    private Rigidbody2D rigidBody2D;
    private BoxCollider2D boxColl2D;
    private Animator anim;
    [SerializeField] private LayerMask jumpableGround;

    private PenguinSliding penguinSlidingScr;

    [Range(1,10)]
    public float jumpVelocity;

    public AudioSource jumpingSFX, walkingSFX, slidingSFX;

    private void Awake()
    {
        rigidBody2D = transform.GetComponent<Rigidbody2D>();
        boxColl2D = transform.GetComponent<BoxCollider2D>();
        anim = this.GetComponentInChildren<Animator>();
        penguinSlidingScr=GetComponent<PenguinSliding>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpingSFX.Play();
            walkingSFX.Stop();
            rigidBody2D.velocity = Vector2.up * jumpVelocity;
            isPenguinJumping = true;
            isWalking = false;
        }
        else if (IsGrounded()==false && rigidBody2D.velocity.y>0)
        {
            walkingSFX.Stop();
            anim.SetBool("IsLaunching", true);
            
        }
        else if (IsGrounded() == false && rigidBody2D.velocity.y < 7)
        {
            walkingSFX.Stop();
            anim.SetBool("IsLaunching", false);
            anim.SetBool("IsFalling", true);
            
        }
        else if (IsGrounded() == true)
        {
            
            anim.SetBool("JumpEnded", true);
            anim.SetBool("IsFalling", false);
            isPenguinJumping = false;
            if (penguinSlidingScr.slidingCollider2D.enabled==false)
            {
                isWalking = true;
            }

        }
        if (penguinSlidingScr.slidingCollider2D.enabled==true && slidingSFX.isPlaying == false) {
            slidingSFX.Play();
            walkingSFX.Stop();
        }
        if (IsGrounded() && isWalking && walkingSFX.isPlaying == false)
        {
            walkingSFX.Play();
            slidingSFX.Stop();
        }
        

    }

    public bool IsGrounded()
    {
        return Physics2D.BoxCast(boxColl2D.bounds.center, boxColl2D.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

}
