using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public string nextSceneName;

    public GameObject KeyObject;
    [SerializeField] private bool Key = false;
    [SerializeField] private bool Door = false;

    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.tag == "Player")
        {
            if (Key)
            {
                KeyObject.SetActive(false);
            }

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