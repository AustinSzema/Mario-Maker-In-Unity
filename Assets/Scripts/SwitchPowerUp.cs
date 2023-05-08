using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPowerUp : MonoBehaviour
{

    [SerializeField] private GameObject playerDefault;
    [SerializeField] private GameObject playerSuper;
 
    [SerializeField] private GameObject playerFire;

    [SerializeField] private CameraFollowPlayer mainCameraFollowPlayer;

    public void switchPowerUp(string tag)
    {
        Debug.Log(tag);
        switch (tag)
        {
            case "SuperMushroom":


                if (!playerFire.activeSelf)
                {

                    playerSuper.transform.position = playerDefault.transform.position;

                    playerSuper.SetActive(true);

                    playerDefault.SetActive(false);

                    mainCameraFollowPlayer.playerTransform = playerSuper.transform;

                    playerFire.SetActive(false);

                }



                break;

            case "SuperStar":
                break;

            case "FireFlower":

                if (playerDefault.activeSelf)
                {
                    playerFire.transform.position = playerDefault.transform.position;

                }

                if (playerSuper.activeSelf)
                {
                    playerFire.transform.position = playerSuper.transform.position;
                }


                playerFire.SetActive(true);

                playerDefault.SetActive(false);

                playerSuper.SetActive(false);
                
                mainCameraFollowPlayer.playerTransform = playerFire.transform;

                Debug.Log("collected fireflower");

                break;

        }
    }

}
