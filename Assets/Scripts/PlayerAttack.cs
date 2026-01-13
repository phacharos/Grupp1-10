using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    Rigidbody2D rb;
    float thrust = 6.0f;
    float timeStamp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 dirToMouse = Input.mousePosition - posInScreen;
                dirToMouse.Normalize();
                rb.AddForce(dirToMouse * thrust, ForceMode2D.Impulse);

                rb.linearDamping = 3;

                timeStamp = Time.time + 3;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}   

