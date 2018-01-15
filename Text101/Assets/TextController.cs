using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom };
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		}
	}

	void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. " +
					"There are some dirty sheets on the bed and a mirror on the wall. " +
					"The door is locked from the outside.\n\n" +
					"Press S to view the Sheets.\n\n" +
					"Press M to view the Mirror.\n\n" +
					"Press L to view the Lock.";

		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
	}
		
	void state_sheets_0 () {
		text.text = "You can't believe that you sleep in these things. " +
			"Surely it's time someone changed them. " +
			"The pleasures of prison life...\n\n" +
			"Press R to Return to your roaming cell.";

		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
}
