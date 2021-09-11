using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour
{
    public float h1, v1;
    public float speed;
    public float jumpStrength;
    float velocityY1 = 0;

    void Update()
    {
        if (GetComponent<CharacterController>().isGrounded == false)
        {
            velocityY1 -= 9.81f * Time.deltaTime;
        }


        h1 = Input.GetAxis("Horizontal");
        v1 = Input.GetAxis("Vertical");
        var movementVector1 = transform.forward * v1 * speed;

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            velocityY1 = jumpStrength;
        }

        movementVector1.y = velocityY1;
        movementVector1 *= Time.deltaTime;
        GetComponent<CharacterController>().Move(movementVector1);
        transform.Rotate(0, h1, 0);

    }    
}
