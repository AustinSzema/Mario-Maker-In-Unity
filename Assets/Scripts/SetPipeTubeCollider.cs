using UnityEngine;

public class SetPipeTubeCollider : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider;

    [SerializeField] private SpriteRenderer spriteRenderer;

    void Start()
    {
        //Sets the size of the box collider to match the size of the sprite renderer's tiled collider. 
        //This is done because it allows the designers to use the sprite renderers tile functionality to make pipe tubes to their desired length,
        //but when doing so, the BoxCollider2D doesn't scale in size with the sprite so the collider will not match the sprite.
        //This fixes that.
        boxCollider.size = spriteRenderer.size;
    }
}
