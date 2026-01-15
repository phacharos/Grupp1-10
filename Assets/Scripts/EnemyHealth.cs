using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int Ehealth;
    public int EmaxHealth;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ehealth = EmaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt(int amount)
    {
//        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttack>().attacking)
//        {
            Ehealth -= amount;

            if (Ehealth <= 0)
            {
                Destroy(gameObject);
            }
//        }
        
        
    }
}
