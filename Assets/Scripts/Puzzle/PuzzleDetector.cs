using UnityEngine;

public class PuzzleDetector : MonoBehaviour
{
    bool IsPlayerNear = false;
    public GameObject StartButton;
    public GameObject EvenSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            IsPlayerNear = true;
            StartButton.SetActive(true);
            EvenSystem.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            IsPlayerNear = false;
            StartButton.SetActive(false);
            EvenSystem.SetActive(false);
        }
    }


}
