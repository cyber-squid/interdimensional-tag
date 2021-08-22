using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagStateHandler : MonoBehaviour
{
    public bool IsTagger;
    private PlayerControls player; 
    private Collider collision;
    //get player collider here, use to check oncollisionenter
    
    void Start()
    {
        IsTagger = false;
        player = GetComponent<PlayerControls>();
        collision = player.playerColl;
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tag Flag")
        {
            IsTagger = true;
            other.isTrigger = false;
            // ideally this would happen in a separate tag flag handler,
            // where either a function including all this would be called,
            // or there would be an if statement checking for isTrigger being false
            // {
                // activate timer here.
                // have an if statement here, to check: when timer ends,
                // {
                    // isTagger = false;
                    // other.isTrigger = true;
                    // stop and reset timer,
                    // if (timer has not reached its full countdown length before stopping)
                    // {
                        // other player's score will increment
                    // }
                    // and lastly, reset player positions.
                // }
            // }
        }
    }

    private void OnCollisionEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            // call "stop and reset timer" function here.
            player.personalScore++;
        }
    }
}
