using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 20;
    public int jumpforce = 800;
    public float rotspeed = 3;
    Vector2 rotation = Vector2.zero;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    
    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += Input.GetAxis("Mouse Y");
        transform.eulerAngles = rotation * rotspeed;

       // Vector3 move = Input.GetAxis("Vertical") * transform.forward * speed;
       // Vector3 strafe = Input.GetAxis(

       /* float xSpeed = Input.GetAxis("Horizontal") * speed;
        float zSpeed = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector3(xSpeed, rb.velocity.y, zSpeed);
        */

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, jumpforce, 0));
        }
    }
}
