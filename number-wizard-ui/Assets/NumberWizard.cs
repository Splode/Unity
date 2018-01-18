using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
	// Use this for initialization
	int max;
	int min;
	int guess;

	public int maxGuessesAllowed;
	public Text text;

	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		// guess = 500;
		// keep max from resolving to 999
		max += 1;

		guess = Random.Range (min, max);
		text.text = guess.ToString ();
	}

	public void GuessHigher () {
		min = guess;
		NextGuess ();
	}

	public void GuessLower () {
		max = guess;
		NextGuess ();
	}


	void NextGuess () {
		guess = (max + min) / 2;
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene("Win");
		}
	}
}
