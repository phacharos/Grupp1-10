using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject player;

    private void OnTriggerStay2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (collision.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            GetComponent<EnemyPatrol>().enabled = false;

        }
        // fungerar ej, kom på ett sätt att få forskarna att återigen patrullera (i mån av tid) :) (problem troligen att koden börjar vid update så det inom start ej kommer med)
        else
        {
            GetComponent<EnemyPatrol>().enabled = true;
        }
    }
}