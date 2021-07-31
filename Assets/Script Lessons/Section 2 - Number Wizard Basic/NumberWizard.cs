using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int max, min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        //guess = (max + min) / 2;
        int guessMin = min + 1;
        int guessMax = max;
        if (guessMin > guessMax) guessMin = guessMax;
        if (guessMax < guessMin) guessMax = guessMin;

        guess = Random.Range(guessMin, guessMax);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
}
