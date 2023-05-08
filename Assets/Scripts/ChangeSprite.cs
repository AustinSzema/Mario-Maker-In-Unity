using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] private SpriteRenderer objectSpriteRenderer;

    [SerializeField] private Sprite newSprite;

    public void changeSprite()
    {
        objectSpriteRenderer.sprite = newSprite;
    }
}
