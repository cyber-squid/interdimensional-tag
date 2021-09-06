using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    public float h, v;
    public float speed;
    public float jumpStrength;
    float velocityY = 0;

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<CharacterController>().isGrounded == false)
        {
            velocityY -= 9.81f * Time.deltaTime;
        }
        
        h = Input.GetAxis("Horizontal1");
        v = Input.GetAxis("Vertical1");
        var movementVector = transform.forward * v * speed;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            velocityY = jumpStrength;
        }

        movementVector.y = velocityY;
        movementVector *= Time.deltaTime;
        GetComponent<CharacterController>().Move(movementVector);
        transform.Rotate(0, h, 0);
    }
}


