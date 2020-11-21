 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private string name = "Anubis";
    [SerializeField] public int highestNumber;
    [SerializeField] public int lowestNumber;
    private int guess;
    private int previousGuess;

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    private void ResetGame()
    {
        highestNumber += 1;        
        CalculateNextGuess();
    }    

    public void OnPressHigher()
    {
        lowestNumber = guess;
        CalculateNextGuess();
    }

    public void OnPressLower()
    {
        highestNumber = guess;
        CalculateNextGuess();
    }

    private void CalculateNextGuess()
    {
        guess = (highestNumber + lowestNumber) / 2;

        if (guess == previousGuess)
        {
            
        }
        else
        {
            previousGuess = guess;
        }
    }
}
