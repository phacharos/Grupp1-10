using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsPuzzle : MonoBehaviour
{

    public List<Button> button;
    public List<Button> shuffledbutton;
    int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RestartGame();//restart the game
    }

    public void RestartGame()
    {
        counter = 0;
        shuffledbutton = button.OrderBy(a => Random.Range(0, 100)).ToList();//change the value randomly
        for (int i = 1; 1 < 11; i++)//limited the loop/numbers from 1 - 10
        {
            shuffledbutton[i - 1].GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();//talk to the button's children, the text, to change to the correct number
            shuffledbutton[i - 1].interactable = true; //make it pressable (again)
            shuffledbutton[i - 1].image.color = Color.white; //the original color of the puzzle
        }
    }

    public void PressButton(Button button)
    {
        if (int.Parse(button.GetComponentInChildren<TextMeshProUGUI>().text) - 1 == counter) // check if the first button is clicked
        {
            counter++;//increase the number of the button, counter
            button.interactable = false;//disable the button to not let the player click again
            button.image.color = Color.green;

            if (counter == 10) // check if all of the buttons are pressed
            {
                Winresult(true);//win result after pressing all the buttons correctly (true)

            }

            else
            {
                Winresult(false);//same with the above but mark it as (false), yes, the player loses
            }
        }
    }

    public IEnumerator Winresult(bool win)
    {
        if (!win) //haha player lost
        {
            foreach (var button in shuffledbutton)//change all of the incorrect button to red once it pressed wrong
            {
                button.image.color = Color.red;
                button.interactable = false; //no more click for you
            }
        }

        yield return new WaitForSeconds(1f); //wait 2 sec before restart
        RestartGame();
    }//restart


    // Update is called once per frame
    void Update()
    {

    }
}
