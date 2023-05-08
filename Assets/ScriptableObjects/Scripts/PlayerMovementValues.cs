using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerMovementValues",
    fileName = "New PlayerMovementValues")]

public class PlayerMovementValues : ScriptableObject
{
    public float moveSpeed = 8f;

    public float jumpHeight = 10f;

    public float downGravity = 1.1f;

    public float fallSpeed = 1.075f;

}
