using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerParasite : MonoBehaviour
{
    bool isPlayerNearby = false;
    bool parasite = false;
    public GameObject enemy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    // påbörjad parasit funktion men kommer förmodligen inte fortsätta på

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && (isPlayerNearby == true))
        {
            transform.position = enemy.transform.position;
            enemy.transform.parent = transform;
            parasite = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && (parasite == true))
        {
           
        }

        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNearby = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
    }
}
