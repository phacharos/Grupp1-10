using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    // Definerar variabler
    public string nextSceneName;

    public GameObject KeyObject;
  
    // Används för att se om objektet är nyckeln eller dörren
    [SerializeField] private bool Key = false;
    [SerializeField] private bool Door = false;

    // Om något kolliderar...
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        // ... och det är spelaren...
        if (collision2D.tag == "Player")
        {
            // ... och objektet är nyckeln inaktiveras den och syns inte längre i scenen
            if (Key)
            {
                KeyObject.SetActive(false);
            }

            // Om nyckeln är inaktiverad kan man gå genom dörren och spelet byts till nästa scen
            if (KeyObject.activeSelf == false)
            {
                if (Door)
                {
                    if (collision2D.GetComponent<Rigidbody2D>() != null)
                    {
                        SceneManager.LoadScene(nextSceneName);
                    }
                }
            }
        }
    }
}