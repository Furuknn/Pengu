using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinSliding : MonoBehaviour
{
    public bool isSliding = false;

    public PenguinMovement penguinMovement;
    public Rigidbody2D rigidbody;
    public Animator animator;

    public BoxCollider2D regularCollider2D;
    public BoxCollider2D slidingCollider2D;

    public float slideSpeed = 5f;

    private void Update()
    {
        if (penguinMovement.IsGrounded() && Input.GetKey(KeyCode.S) && penguinMovement.isPenguinJumping==false)
        {
            performSlide();
            
            
        }
        else if(!Input.GetKey(KeyCode.S))
        {
            isSliding = false;
            animator.SetBool("IsSliding", false);
            regularCollider2D.enabled = true;
            slidingCollider2D.enabled = false;
        }
    }

    private void performSlide()
    {
        isSliding = true;

        animator.SetBool("IsSliding", true);
        regularCollider2D.enabled = false;
        slidingCollider2D.enabled = true;
    }



}
