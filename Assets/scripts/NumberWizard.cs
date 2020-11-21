 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private static string name = "Anubis";
    [SerializeField] public int highestNumber;
    [SerializeField] public int lowestNumber;
    private static int guess;
    private static int previousGuess;

    // Start is called before the first frame update
    void Start()
    {        
        GreetPlayer();
        ResetGame();
    }

    private void GreetPlayer()
    {
        Debug.Log("Halt mortal! Who goes there?");
        Debug.Log("So " + name + ", get ready to be amazed by tne Number Wizard!");
        Debug.Log("Pick a number and prepare to have your brain blown!");
    }

    private void ResetGame()
    {
        bool keepGoing = true;
        highestNumber = 1000;
        lowestNumber = 1;
        previousGuess = 0;
        Debug.Log("The highest number you can pick is: " + highestNumber);
        Debug.Log("The lowest number you can pick is: " + lowestNumber);
        CalculateNextGuess();        
        Debug.Log("Push Up = Higher, Push Down = Lower, Push ENTER = Correct!");
        highestNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Detect which key was pressed
        foreach (KeyCode keyPressed in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(keyPressed))
            {
                switch (keyPressed)
                {
                    case KeyCode.Return:
                        Debug.Log("I knew it from the very beginning!");
                        ResetGame();
                        break;
                    case KeyCode.UpArrow:
                        lowestNumber = guess;
                        CalculateNextGuess();

                        break;
                    case KeyCode.DownArrow:
                        highestNumber = guess;
                        CalculateNextGuess();
                        break;
                    case KeyCode.Escape:
                        Debug.Log("Later loser!");
                        break;
                    default:
                        Debug.Log("I haven't got all day for this");
                        break;
                }
            }
        }
    }

    public void OnPressHigher()
    {

    }

    public void OnPressLower()
    {

    }

    private static void CalculateNextGuess()
    {
        guess = (highestNumber + lowestNumber) / 2;
        Debug.Log("Now, is your number is higher or lower than: " + guess);

        if (guess == previousGuess)
        {
            Debug.Log("Okay, now you are just wasting my time!");
        }
        else
        {
            previousGuess = guess;
        }
    }
}
