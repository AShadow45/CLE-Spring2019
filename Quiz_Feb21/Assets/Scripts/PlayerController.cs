using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;
    int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key")
        {
            count = count + 1;
            print("Collected Key");
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Door")
        {
            print("Hit Door but no key");
            if (count == 1)
            {
                print("Hit Door");
                SceneManager.LoadScene("Win");
            }
        }
    }

}
