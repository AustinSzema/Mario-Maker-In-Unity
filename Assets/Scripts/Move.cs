using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    
    [SerializeField] private PlayerMovementValues playerMovementValues;

    private float moveSpeed;

    private Vector2 direction;


    private void Start()
    {
        moveSpeed = playerMovementValues.moveSpeed;
    }

    private void FixedUpdate()
    {

        direction = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);

        playerRB.velocity = direction;


    }
}
