using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    [HideInInspector]
    public bool isGrounded;


    private void OnTriggerEnter2D(Collider2D col)
    {
        isGrounded = true;
    }


    private void OnTriggerStay2D(Collider2D col)
    {
        isGrounded = true;
    }



    private void OnTriggerExit2D(Collider2D col)
    {
        isGrounded = false;
    }





}
