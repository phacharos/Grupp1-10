using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody2D rb;
    int speed = 4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocityY = speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocityY = -speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX = speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX = -speed;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.linearVelocityY = 0;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.linearVelocityY = 0;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.linearVelocityX = 0;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.linearVelocityX = 0;
        }
    }
}
