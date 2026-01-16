using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject player;

    public float speed = 1.5f;
    public Animator animator;

    public AudioSource pewpew;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }



    void Update()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance < 5)
        {
            timer += Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            GetComponent<EnemyPatrol>().enabled = false;

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
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
