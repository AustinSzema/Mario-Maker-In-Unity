using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;

    [SerializeField] private PlayerMovementValues playerMovementValues;

    [SerializeField] private GroundDetector groundDetector;

    private float jumpHeight;

    private Vector2 direction;

    private void Start()
    {
        jumpHeight = playerMovementValues.jumpHeight;
    }


    private void FixedUpdate()
    {
        if (Input.GetKey("space") && groundDetector.isGrounded == true)
        {

            direction = new Vector2(playerRB.velocity.x, jumpHeight);

            playerRB.velocity = direction;


        }
    }

}
