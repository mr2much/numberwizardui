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
    }    

    public void OnPressHigher()
    {
        if(guess < highestNumber)
        {
            lowestNumber = guess + 1;
            CalculateNextGuess();
        }        
    }

    public void OnPressLower()
    {
        if(guess > lowestNumber)
        {
            highestNumber = guess - 1;
            CalculateNextGuess();
        }        
    }

    private void CalculateNextGuess()
    {
        guess = Random.Range(lowestNumber, highestNumber + 1);

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
