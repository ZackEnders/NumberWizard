using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame () {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Please pick a number");
        Debug.Log("The highest number can be: " + max);
        Debug.Log("The lowest number can be: " + min);
        Debug.Log("Push up arrow = higher, push down arrow = lower, push enter key if correct");
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        max = max + 1;
    }
	// Update is called once per frame
	void Update () {

        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            min = guess;
            NextGuess();
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        } 
        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("I am a genius!");
            StartGame();
        }

    }
    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
