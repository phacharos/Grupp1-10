using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

    int hurtAmount = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth Ehealth = collision.GetComponent<EnemyHealth>();

        if (Ehealth == null)
        {
            return;
        }

        Ehealth.Hurt(hurtAmount);
        //Destroy(gameObject);
    }
}
