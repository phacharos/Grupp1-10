using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
   // Button btn;
    
    public string nextSceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        btn = GetComponent<Button>();

        if (btn != null)
        {
            btn.onClick.AddListener(() =>
            {
                ChangeSceneTo();
            });
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ChangeSceneTo();
        }
    }

    public void ChangeSceneTo()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
