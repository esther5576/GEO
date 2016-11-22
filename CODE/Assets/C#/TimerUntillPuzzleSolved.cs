using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerUntillPuzzleSolved : MonoBehaviour
{
	//Le timer sert a savoir combien de temps le joueur à pris pour trouver la bonne couleur

	public float m_fTimer;
	public Text m_pText;
	public PuzzleRules m_pPuzzleRulesScript;
	public GameObject m_pEndGameCanvas;

	// Use this for initialization
	void Awake ()
	{
		m_pText = GameObject.Find ("UICanvasEndGame/Timer").GetComponent<Text> ();
		m_pEndGameCanvas = GameObject.Find ("UICanvasEndGame");
		m_pEndGameCanvas.SetActive (false);
		m_pPuzzleRulesScript = this.GetComponent<PuzzleRules> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (m_pPuzzleRulesScript.m_bWin == false) {
			m_fTimer += Time.deltaTime;
		}
	}

	public void WinGame ()
	{
		m_pEndGameCanvas.SetActive (true);
		m_pText.text = "It took you " + m_fTimer + " seconds to find the correct color!";
	}
}
