 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    private string name = "Anubis";
    [SerializeField] int highestNumber;
    [SerializeField] int lowestNumber;
    [SerializeField] TextMeshProUGUI guessText;
    private int guess;
    private int previousGuess;

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    private void ResetGame()
    {        
        CalculateNextGuess();
        highestNumber += 1;
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

        guessText.text = guess.ToString();
    }
}
