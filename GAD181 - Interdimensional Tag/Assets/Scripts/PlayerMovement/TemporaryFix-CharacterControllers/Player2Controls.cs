using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controls : MonoBehaviour
{
    public float h2, v2;
    public float speed;
    public float jumpStrength;
    float velocityY2 = 0;

    void Update()
    {
        if (GetComponent<CharacterController>().isGrounded == false)
        {
            velocityY2 -= 9.81f * Time.deltaTime;
        }

        h2 = Input.GetAxis("Horizontal2");
        v2 = Input.GetAxis("Vertical2");
        var movementVector2 = transform.forward * v2 * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocityY2 = jumpStrength;
        }

        movementVector2.y = velocityY2;
        movementVector2 *= Time.deltaTime;
        GetComponent<CharacterController>().Move(movementVector2);
        transform.Rotate(0, h2, 0);
    }
}
