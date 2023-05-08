using UnityEngine;

public class SetPlayerStartPos : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3Variable playerStartPos;

    void Start()
    {
        playerStartPos.Value = playerTransform.position;
        
    }

}
