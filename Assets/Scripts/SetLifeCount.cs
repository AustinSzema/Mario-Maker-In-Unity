using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetLifeCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lifeCountText;

    [SerializeField] private intVariable lifeCount;

    private void Awake()
    {
        if(lifeCount.Value <= 0)
        {
            lifeCount.Value = 3;

        }
    }

    void Update()
    {
        lifeCountText.text = "" + lifeCount.Value;
    }
}
