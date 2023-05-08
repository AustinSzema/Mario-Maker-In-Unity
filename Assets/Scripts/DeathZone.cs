using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private intVariable lifeCount;

    [SerializeField] private Vector3Variable playerStartPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            lifeCount.Value--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            collision.gameObject.SetActive(false);
        }
    }
}

