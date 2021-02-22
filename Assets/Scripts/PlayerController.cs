using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // rate of foward/backward movement
    private float speed = 15.0f;
    private float turnSpeed = 15.0f;
    // hold user input vertical and horizontal
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Get user input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //accelerate vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //turning vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
