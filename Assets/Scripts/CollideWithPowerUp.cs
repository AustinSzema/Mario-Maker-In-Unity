using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPowerUp : MonoBehaviour
{
    [SerializeField] private SwitchPowerUp _switchPowerUp;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("PowerUp"))
        {
            _switchPowerUp.switchPowerUp(collision.gameObject.tag);
            collision.gameObject.SetActive(false);
        }

    }
}
