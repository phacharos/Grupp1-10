using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Definerar variabler
    private GameObject player;
    private Rigidbody2D rb;
    public float force;

    private float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hittar spelaren och rigidbodyn
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        // Gör så kulan åker mot spelaren samt roterar lite
        Vector3 direction = player.transform.position - transform.position;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
    }

    // Update is called once per frame
    void Update()
    {
        // Skapar timer
        timer += Time.deltaTime;

        // "Om det har gått mer än 10 sekunder förstörs kulan"
        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }

    // Om kulan kolliderar med spelaren förlorar spelaren 20 i hälsa, sedan förstörs den
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().health -= 20;
            Destroy(gameObject);
        }
    }
}
