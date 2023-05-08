using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlayer : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;

    [SerializeField] private Rigidbody2D playerRB;

    private void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            playerTransform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            playerTransform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }

}
