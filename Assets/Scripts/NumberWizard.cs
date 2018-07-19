using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
   [SerializeField] int max;
   [SerializeField] int min;
   [SerializeField] TextMeshProUGUI guessText;


    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
        
    }

    
    void StartGame()
    {
        NextGuess();
    }

    public void OnKeyPressUp()
    {
        {
            min = guess + 1;
            NextGuess();
            if (guess > 1000)
                guess = 1000;
        }
        

    }

    public void OnKeyPressDown()
    {
        {
            max = guess + 1;
            NextGuess();
            if (guess < 1)
                guess = 1;
        }
    }
        


    void NextGuess()
    {
        guess = Random.Range(min, max); ;
        guessText.text = guess.ToString();
    }
}
        
	
