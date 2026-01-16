using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayTrigger()
    {
        SceneManager.LoadScene(1); //<- eller annan scen
        //Bytt till scen ett (1) när spelare trycker här
    }

    public void OnQuitTrigger()
    {
        Application.Quit();
        //gå ut från spelet när spelare trycker här
    }
}
