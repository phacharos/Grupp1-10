using UnityEngine;
using UnityEngine.LowLevelPhysics;

public class InteractingE : MonoBehaviour
{
    //Makes "trigger active" buttom appear on the inspector (:O
    [SerializeField] bool TriggerActive = false;
    SpriteRenderer SR;

    public Sprite CageDestroy;
    public GameObject Cage;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();

    }
    private void OnTriggerEnter2D(Collider2D collider2d)//collider2d is the name of the other objects with Collider2D nearby, which means it can be anything around this object
                                                        //when the Object with tag "player" is near this object
    {
        if (collider2d.CompareTag("Player"))
        {
            TriggerActive = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collider2D)//when "player" exit, is far away from the object
    {
        if (collider2D.CompareTag("Player"))
        {
            TriggerActive = false;

        }
    }
    // Update is called once per frame
    void Update()
    {

        /* Try code to hit more than 3 times
        if (Input.GetKeyDown(KeyCode.E) && TriggerActive)
        {
            print("I might need more than once.");
            SR.color = Color.gray5;

            if (Input.GetKeyDown(KeyCode.E) && TriggerActive)
            {
                print("Again!.");

                if (Input.GetKeyDown(KeyCode.E) && TriggerActive)
                {
                    Action();
                }
            }
        }
        */

        if (Input.GetKeyDown(KeyCode.E) && TriggerActive)
        {
            Cage.GetComponent<SpriteRenderer>().sprite = CageDestroy;
            Cage.GetComponent<SpriteRenderer>().sortingOrder = -1;

            Action();
        }




    }


    public void Action()
    {
        print("YES!!");
        Destroy(gameObject);


    }

}

