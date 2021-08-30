using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEnable : MonoBehaviour
{ 
    // to be added to each powerup. enum type determines what powerup it is
    public enum PowerTypeList
    {
        Empty,
        SpeedUp,
        MoonJump,
        PlaceTrap,
        GrappleHook
    };

    public PowerTypeList PowerType;
    public PlayerControls playerController;
    //int PowerTypeNum = (int)PowerType;

    public int speedBoost = 3;
    public int jumpBoost = 5;


    void OnTriggerEnter(Collider body)
    {
        if (body.tag == "Player")
        {
            playerController = body.GetComponent<PlayerControls>();
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
                SpeedUp(playerController);
                // continue until timer ends
                break;

            case PowerTypeList.MoonJump:
                // do other thing
                // eg: poweredPlayer.speed += jumpBoost;
                MoonJump(playerController);
                break;

            case PowerTypeList.PlaceTrap:
                // do another thing
                PlaceTrap(playerController);
                break;

            case PowerTypeList.GrappleHook:
                // do yet another thing
                GrappleHook(playerController);
                break;

            default:
                Debug.Log("Pickup was an invalid item type.");
                break;
        }
        //
        //Destroy(particle_effect);
        Destroy(this.gameObject);
    }

    void SpeedUp(PlayerControls player)
    {

    }

    void MoonJump(PlayerControls player)
    {

    }

    void PlaceTrap(PlayerControls player)
    {

    }

    void GrappleHook(PlayerControls player)
    {

    }
}
