using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;


    [SerializeField] private Rigidbody2D playerRB;


    [SerializeField] private GroundDetector groundDetector;

    private void FixedUpdate()
    {

        animator.SetFloat("Speed", Mathf.Abs(playerRB.velocity.x));

        animator.SetBool("IsJumping", !groundDetector.isGrounded);

    }
}
