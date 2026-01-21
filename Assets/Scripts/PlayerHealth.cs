using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Definerar variabler
    public string nextSceneName;

    public float health;
    public float maxHealth;
    public Image healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hälsan börjar som det maxhälsan är inställd på
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        // "Baren" blir mindre allt eftersom spelarens hälsa går ner
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        // Om hälsan är mindre eller lika med 0 dör spelaren
        if (health <= 0 )
        {
            Destroy(gameObject);

            //ladda game over scenen
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
