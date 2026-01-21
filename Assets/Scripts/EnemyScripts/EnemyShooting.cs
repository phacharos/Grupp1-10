using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Definerar variabler

    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject player;

    public float speed = 1.5f;
    public Animator animator;

    public AudioSource pewpew;

    void Start()
    {
        // Hittar spelaren
        player = GameObject.FindGameObjectWithTag("Player");

    }



    void Update()
    {
        // Räknar ut distansen mellan spelaren och fienden
        float distance = Vector2.Distance(transform.position, player.transform.position);

        // Om distansen är mindre än 5 börjar forskaren gå mot spelaren...
        if (distance < 5)
        {
            timer += Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            // ... samt slutar patrullera
            GetComponent<EnemyPatrol>().enabled = false;

            // Om det har gått mer än en sekund börjar forskaren skjuta, och timern startas om. Alltså skjuts ett skott i sekunden.
            if (timer > 1)
            {
                timer = 0;
                shoot();
                pewpew.Play();
            }
        }
        // kan tas bort, gör att den går tillbaka till patrull
        else
        {
            GetComponent<EnemyPatrol>().enabled = true;
        }
    }

    // Kulan skapas
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}