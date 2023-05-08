using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect1Up : MonoBehaviour
{
    [SerializeField] private intVariable lifeCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            lifeCount.Value++;
            gameObject.SetActive(false); //deactivates the 1Up after it gets collected
        }
    }
}
