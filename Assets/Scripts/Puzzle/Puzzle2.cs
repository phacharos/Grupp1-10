using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    [SerializeField] int nextbutton;
    [SerializeField] GameObject GamePanel;
    [SerializeField] GameObject[] myObject;
    public GameObject Exitdoor;
    public GameObject StartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextbutton = 0;
    }

    private void OnEnable()
    {
        nextbutton = 0;
        for (int i = 0; i < myObject.Length; i++)
        {
            myObject[i].transform.SetSiblingIndex(Random.Range(0, 8));//reset the game & the button's positions
        }
    }

    public void ButtonOrder(int button)
    {
        Debug.Log("Pressed");
        if (button == nextbutton)
        {
            nextbutton++;
            Debug.Log("Next button" + nextbutton);
        }
        else
        {
            Debug.Log("Failed");
            Debug.Log("Next button" + nextbutton);
            nextbutton = 0;
            OnEnable();//reset the game
        }
        if (button == 8)// idk why it does NOT work!!!
        {
            Debug.Log("Pass & the exit has opened");
            nextbutton = 0;
            GamePanel.SetActive(false);
            Destroy(GamePanel);
            Destroy(Exitdoor);
            Destroy(StartButton);

        }
    }


    public void ButtonPanelClose()
    {
        GamePanel.SetActive(false);
    }

    public void ButtonPanelOpen()
    {
        GamePanel.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
