using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    [SerializeField] private Transform cameraTransform;


    public Transform playerTransform;


    //[SerializeField] private Vector3 cameraOffset;


   //private float xDist;
    private float yDist;

    private Vector3 distance;

    void Update()
    {
        //xDist = cameraTransform.position.x - playerTransform.position.x;

        yDist = cameraTransform.position.y - playerTransform.position.y;

        distance = new Vector3(playerTransform.position.x, yDist + playerTransform.position.y, cameraTransform.position.z);

        cameraTransform.position = distance;
        
    }
}
