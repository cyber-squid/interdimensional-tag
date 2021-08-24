using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagStateHandler : MonoBehaviour
{
    public bool IsTagger;
    private PlayerControls player; 
    //get player collider here, use to check oncollisionenter

    private Collider tagFlag;

    private Timer timer;
    
    void Start()
    {
        IsTagger = false;
        player = GetComponent<PlayerControls>();
        //tagFlag = TryGetComponent < GameObject.Find("Tag Flag") > ();
    }

    //TODO: move the code for handling flag states to its own separate script, so both player's tag
    //scripts aren't trying to call the reset functions. 
    void Update()
    {
        if (timer.remainingTime <= 0)
        {
            ResetFlag();
            timer.ResetTimer();
            if (!IsTagger)
            {
                player.personalScore++;
            }
            IsTagger = false;
            // reset player positions.
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tag Flag")
        {
            IsTagger = true;
            tagFlag.isTrigger = false;
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
            timer.BeginCountdown();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            ResetFlag();
            timer.ResetTimer();
            if (IsTagger)
            {
                player.personalScore++;
                IsTagger = false;
            }
            // reset player positions.
        }
    }
    private void ResetFlag()
    {
        tagFlag.isTrigger = true;
        // reset flag's position.
    }
}

