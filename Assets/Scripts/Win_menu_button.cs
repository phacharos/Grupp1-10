using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_menu_button : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }
    public void NextScene()
    {
        Debug.Log("Button Worked");
        SceneManager.LoadScene("StartSceneTest");
    }

}
