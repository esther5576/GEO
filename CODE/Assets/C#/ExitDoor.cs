using UnityEngine;
using System.Collections;

public class ExitDoor : MonoBehaviour
{
	public TimerUntillPuzzleSolved _endGame;

	// Use this for initialization
	void Awake ()
	{
		_endGame = GameObject.Find ("PuzzleManager").GetComponent<TimerUntillPuzzleSolved> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.name == "Main Camera") {
			_endGame.WinGame ();
		}

	}
}
