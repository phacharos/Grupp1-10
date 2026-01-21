using System.Collections;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // Definerar variabler

    public Transform waypointParent;
    public float moveSpeed = 2f;
    public float waitTime = 2f;
    
    // Loopar så forskarna inte stannar vid en punkt
    public bool loopWaypoints = true;

    private Transform[] waypoints;
    private int currentWaypointIndex;
    private bool isWaiting;

    public Animator animator;

    void Start()

    {
        // Räknar ut hur många waypoints som finns
        waypoints = new Transform[waypointParent.childCount];

        for (int i = 0; i < waypointParent.childCount; i++)
        {
            waypoints[i] = waypointParent.GetChild(i);
        }
    }

    // "Om spelaren väntar börja inte gå mot nästa waypoint, annars fortsätt gå"
    private void Update()
    {
        if (isWaiting)
        {
            return;
        }

        MoveToWaypoint();
    }

    void MoveToWaypoint()
    {
        // Hittar och går mot nästa waypoint
        Transform target = waypoints[currentWaypointIndex];

        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        // Om distansen mellan spelaren är mindre än 0.1 börjar den vänta
        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            StartCoroutine(WaitAtWaypoint());
        }
    }

    // Väntar på waypoint en viss tid man väljer själv
    IEnumerator WaitAtWaypoint()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);

        currentWaypointIndex = loopWaypoints ? (currentWaypointIndex + 1) % waypoints.Length : Mathf.Min(currentWaypointIndex + 1, waypoints.Length - 1);

        isWaiting = false;
    }
}
