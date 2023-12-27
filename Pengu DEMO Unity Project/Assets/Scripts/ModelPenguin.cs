using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPenguin : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("PlayAnimation", true);
        Time.timeScale = 1.0f;
    }
}
