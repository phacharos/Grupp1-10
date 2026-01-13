using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public string nextSceneName;

    public float health;
    public float maxHealth;
    public Image healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0 )
        {
            Destroy(gameObject);
            //ladda game over scenen i stället :)
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
