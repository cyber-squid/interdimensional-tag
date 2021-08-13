using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEnable : MonoBehaviour
{ 

    public PlayerControls player;
    public enum PowerTypeList
    {
        Empty,
        SpeedUp,
        MoonJump,
        PlaceTrap,
        GrappleHook
    };
    public PowerTypeList PowerType;
    //int PowerTypeNum = (int)PowerType;

    public int speedBoost = 3;

    void OnTriggerEnter(Collider body)
    {
        if (body.tag == "Player")
        {
            player = body.GetComponent<PlayerControls>();
            ActivatePower();
        }
    }

    void ActivatePower()
    {
        switch (PowerType)
        {
            case PowerTypeList.SpeedUp:
                // do thing
                // eg: poweredPlayer.speed += speedBoost;
                player.speed += speedBoost;
                // continue until timer ends
                break;

            case PowerTypeList.MoonJump:
                // do other thing
                // eg: poweredPlayer.speed += jumpBoost;
                break;

            case PowerTypeList.PlaceTrap:
                // do another thing
                break;

            case PowerTypeList.GrappleHook:
                // do yet another thing
                break;

            default:
                Debug.Log("Pickup was an invalid item type.");
                break;
        }
        //
        //Destroy(particle_effect);
        Destroy(this.gameObject);
    }
}
