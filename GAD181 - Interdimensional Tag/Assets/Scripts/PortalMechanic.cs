using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMechanic : MonoBehaviour
{
    protected GameObject portalA;
    protected GameObject portalB;
    protected PlayerControls player;

    void Start()
    {
        portalA = transform.Find("Portal A").gameObject;
        portalB = transform.Find("Portal B").gameObject;
    }

    private void OnTriggerEnter(Collider teleportee)
    {
        if (teleportee.gameObject.tag == "Player")
        {
            player = teleportee.GetComponent<PlayerControls>();
        }
    }

    protected void SetPlayerPosition(PlayerControls teleportee, GameObject portal)
    {
        teleportee.enabled = true;
        teleportee.transform.position = portal.transform.position;
    }
}
