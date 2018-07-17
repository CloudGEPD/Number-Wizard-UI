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
        max += max;
        guess = (max + min) / 2;
        guessText.text = guessText.ToString();
    }

    void OnKeyPressUp()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

    }

    void OnKeyPressDown()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
        
	
