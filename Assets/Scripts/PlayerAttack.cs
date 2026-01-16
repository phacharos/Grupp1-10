using UnityEditor;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

   /* Rigidbody2D rb;
    float thrust = 6.0f;
    float timeStamp;
    public bool attacking = false;

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
                attacking = true;
                Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 dirToMouse = Input.mousePosition - posInScreen;
                dirToMouse.Normalize();
                rb.AddForce(dirToMouse * thrust, ForceMode2D.Impulse);

                rb.linearDamping = 3;

                timeStamp = Time.time + 2.5f;
            }
            else
            {
                attacking = false;
            }
            

        }

        if (attacking == true)
        {
            GetComponent<test>().enabled = false;
            GetComponent<HurtEnemy>().enabled = true;
        }
        if (attacking == false)
        {
            GetComponent<test>().enabled = true;
            GetComponent<HurtEnemy>().enabled = false;
        }
    }*/
}   

