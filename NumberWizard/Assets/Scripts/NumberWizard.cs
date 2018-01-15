using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	// Use this for initialization
	int max;
	int min;
	int guess;

	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		guess = 500;
		min = 1;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");

		print ("The highest number that you can pick is " + max);
		print ("The lowest number that you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Press the UP arrow key for higher, DOWN arrow key for lower, and ENTER for equal");

		max += 1;
	}

	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is your number higher or lower than " + guess + "?");
		print ("Press the UP arrow key for higher, DOWN arrow key for lower, and ENTER for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won.");
			StartGame ();
		}
	}
}
