using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : PortalMechanic
{

    private void OnTriggerEnter(Collider teleportee)
    {
        if (teleportee.gameObject.tag == "Player")
        {
            player = teleportee.GetComponent<PlayerControls>();

            if (name == "Portal A")
            {
                player.transform.position += new Vector3(0,500,0);
                player.enabled = false;
                //send player to portal B.
                //player.transform.position = portalB.transform.position;
                new WaitForSeconds(5);
                SetPlayerPosition(player, portalB);
            }
            if (name == "Portal B")
            {
                player.transform.position += new Vector3(0, 500, 0);
                player.enabled = false;
                //send player to portal A.
                //player.transform.position = portalA.transform.position;
                new WaitForSeconds(5);
                SetPlayerPosition(player, portalA);
            }
        }
    }
}
