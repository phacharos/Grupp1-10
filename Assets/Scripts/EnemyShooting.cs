using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;
    Animator animator;

    private float timer;
    private GameObject player;

    public float speed = 1.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator.GetComponent<Animator>();
    }

    void Update()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if (distance < 5)
        {
            timer += Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            GetComponent<EnemyPatrol>().enabled = false;

            if (timer > 1)
            {
                timer = 0;
                shoot();
                animator.Play("EnemyAttact");
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
