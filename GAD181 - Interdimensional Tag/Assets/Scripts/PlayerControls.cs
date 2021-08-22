using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody playerBody;
    public Collider playerColl;


    public Vector3 moveForce;
    public float speed = 3;
    public float jumpForce = 3;

    public int personalScore;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        moveForce.x = Input.GetAxis("Horizontal");
        moveForce.z = Input.GetAxis("Vertical");

        //tagHandler = GetComponent<TagStateHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        playerBody.velocity += moveForce * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //playerBody += jumpForce;
        }
    }

}
