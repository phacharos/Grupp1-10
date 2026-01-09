using UnityEngine;

public class playercontrol : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Restriktionerna är inte klara, fixa senare så att det blir rätt dimensioner :)

        rb.linearVelocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4)
            {
                rb.linearVelocity = new Vector2(-3, 0);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 2)
            {
                rb.linearVelocity = new Vector2(0, 3);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 2)
            {
                rb.linearVelocity = new Vector2(3, 0);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -2)
            {
                rb.linearVelocity = new Vector2(0, -3);
            }
        }
    }
}
