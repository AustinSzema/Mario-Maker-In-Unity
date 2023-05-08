using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{


    [SerializeField] private GameObject itemPrefab;

    [SerializeField] private Transform itemSpawnPointTransform;


    public void spawnItem()
    {
        Instantiate(itemPrefab, itemSpawnPointTransform.position, Quaternion.identity);
    }

}
