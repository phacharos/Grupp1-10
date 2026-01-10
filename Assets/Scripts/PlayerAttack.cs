using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    Rigidbody2D rb;
    float thrust = 6.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dirToMouse = Input.mousePosition - posInScreen;
            dirToMouse.Normalize();
            rb.AddForce(dirToMouse * thrust, ForceMode2D.Impulse);
        }
    }
}
