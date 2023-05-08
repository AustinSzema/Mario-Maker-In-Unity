using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    [SerializeField] private Rigidbody2D objectRigidbody;

    enum direction {left, right};

    [SerializeField] private direction moveDirection;

    [SerializeField] private float speed = 2f;

    private Vector2 moveVector;


    private void FixedUpdate()
    {

        if(moveDirection == direction.left)
        {
            moveVector = new Vector2(-speed, objectRigidbody.velocity.y);
        }
        else
        {
            moveVector = new Vector2(speed, objectRigidbody.velocity.y);
        }


        objectRigidbody.velocity = moveVector;
    }
}
