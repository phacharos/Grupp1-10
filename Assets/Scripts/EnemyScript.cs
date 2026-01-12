using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 1.5f;

    public GameObject player;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (collision.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
