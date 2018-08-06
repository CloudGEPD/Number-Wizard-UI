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
        NextGuess();
    }

    private void Update()
    {
        OnKeyPressUp();
        OnKeyPressDown();
    }


    public void OnKeyPressUp()
    
    {
        {
            if (guess > 1000)
                guess = 1000;
            min = guess;
            NextGuess();
            
        }
        

    }

    public void OnKeyPressDown()
    {
        {
            max = guess;
            NextGuess();
            if (guess < 1)
                guess = 1;

        }
    }
        


    void NextGuess()
    {
        Random.Range(min +1, max);
        guessText.text = guess.ToString();
    }
}
        
	
       

   

  

    
