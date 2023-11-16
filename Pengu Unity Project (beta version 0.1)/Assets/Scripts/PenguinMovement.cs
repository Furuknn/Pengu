using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovement : MonoBehaviour
{
    
    private Rigidbody2D rigidBody2D;
    [Range(1,10)]
    public float jumpVelocity = 7f;

    private void Awake()
    {
        rigidBody2D = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody2D.velocity = Vector2.up * jumpVelocity;
        }
    }

    

}
