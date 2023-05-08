using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetCoinCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinCountText;

    [SerializeField] private intVariable coinCount;

    private void Start()
    {
        coinCount.Value = 0;
    }

    void Update()
    {
        coinCountText.text = "" + coinCount.Value;
    }
}
