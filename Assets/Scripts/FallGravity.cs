using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGravity : MonoBehaviour
{

    [SerializeField] private Rigidbody2D playerRB;

    [SerializeField] private PlayerMovementValues playerMovementValues;

    private float downGravity;

    private float fallSpeed;


    private Vector2 direction;

    private Vector2 lastVelocity;


    private void Start()
    {
        downGravity = playerMovementValues.downGravity;
        fallSpeed = playerMovementValues.fallSpeed;
    }

    private void FixedUpdate()
    {
        

        if (playerRB.velocity.y < lastVelocity.y)
        {
            direction = new Vector2(playerRB.velocity.x, playerRB.velocity.y - downGravity * Time.fixedDeltaTime);

            playerRB.velocity = direction;
        }


        if (playerRB.velocity.y < 0)
        {
            direction = new Vector2(playerRB.velocity.x, playerRB.velocity.y * fallSpeed);

            playerRB.velocity = direction;
        }



        lastVelocity = playerRB.velocity;


    }


}
