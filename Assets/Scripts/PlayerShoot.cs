using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject projectile;
    public Transform projectilePos;
    float timeStamp;
    float thrust = 6;
    

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
            if (Input.GetKey(KeyCode.Mouse0))
            {
                
                Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 dirToMouse = Input.mousePosition - posInScreen;
                dirToMouse.Normalize();
                GameObject project = Instantiate(projectile, projectilePos.position, Quaternion.identity);
                project.GetComponent<Rigidbody2D>().linearVelocity = dirToMouse * thrust;

                timeStamp = Time.time + 0.5f;
            }
        }
    }
}

