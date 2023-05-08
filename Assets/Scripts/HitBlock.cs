using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour
{

    enum blockType {Question, Brick, Used};

    [SerializeField] private blockType block;

    [SerializeField] private SpawnItem _spawnItem;
    [SerializeField] private ChangeSprite _changeSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch (block)
            {
                case blockType.Question:

                    _spawnItem.spawnItem();


                    block = blockType.Used;

                    _changeSprite.changeSprite();

                    break;



                case blockType.Brick:

                    _spawnItem.spawnItem();


                    block = blockType.Used;

                    _changeSprite.changeSprite();

                    break;


                case blockType.Used:

                    break;


            }

        }
    }
}
