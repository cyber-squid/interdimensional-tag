using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterControllerExperimental : MonoBehaviour
{
    public float h1, h2, v1, v2;
    public float speed;
    public float jumpStrength;
    float velocityY1, velocityY2 = 0;
    public GameObject Player1GO, Player2GO;

    void Update()
    {
        if(Player1GO.GetComponent<CharacterController>().isGrounded == false)
        {
            velocityY1 -= 9.81f * Time.deltaTime;
        }

        if (Player2GO.GetComponent<CharacterController>().isGrounded == false)
        {
            velocityY2 -= 9.81f * Time.deltaTime;
        }

        h1 = Input.GetAxis("Horizontal1");
        v1 = Input.GetAxis("Vertical1");
        var movementVector1 = transform.forward * v1 * speed;

        h2 = Input.GetAxis("Horizontal2");
        v2 = Input.GetAxis("Vertical2");
        var movementVector2 = transform.forward * v2 * speed;

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            velocityY1 = jumpStrength;
        }

        movementVector1.y = velocityY1;
        movementVector1 *= Time.deltaTime;
        Player1GO.GetComponent<CharacterController>().Move(movementVector1);
        transform.Rotate(0, h1, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocityY2 = jumpStrength;
        }

        movementVector2.y = velocityY2;
        movementVector2 *= Time.deltaTime;
        Player2GO.GetComponent<CharacterController>().Move(movementVector2);
        transform.Rotate(0, h2, 0);
    }
}


