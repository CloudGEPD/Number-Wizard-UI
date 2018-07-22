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
<<<<<<< HEAD
        guessText.text = guess.ToString();
        max += max;
    }

   

    void OnKeyPressUp()
=======
    }

    public void OnKeyPressUp()
>>>>>>> 5f1836589e22cf3d0bc0066f148ac3f2e8b10d9b
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
<<<<<<< HEAD
            print(guess);
=======
            if (guess < 1)
                guess = 1;
>>>>>>> 5f1836589e22cf3d0bc0066f148ac3f2e8b10d9b
        }
    }
        


    void NextGuess()
    {
        guess = Random.Range(min, max); ;
        guessText.text = guess.ToString();
    }
}
        
	
