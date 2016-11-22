using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PuzzleRules : MonoBehaviour
{
	public bool m_bWin;
	//Cubes Manager
	public CubesManager m_pCubesManagerScript;

	//Barre de porgression
	public Slider m_pProgressionBar;

	//Vitesse d'augmentation du slider
	public float m_fSliderSpeed;

	//Collider du portail de l'arche
	public BoxCollider m_pArchCollider;

	//FX du portail
	public GameObject m_pGate;

	// Use this for initialization
	void Awake ()
	{
		m_pCubesManagerScript = GameObject.Find ("CubesManager").GetComponent<CubesManager> ();
		m_pProgressionBar = GameObject.Find ("UICanvasInGame/BarreDeProgression").GetComponent<Slider> ();
		m_pArchCollider = GameObject.Find ("Arch/EntranceTrigger").GetComponent<BoxCollider> ();
		m_pArchCollider.isTrigger = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (m_pCubesManagerScript.m_bColorIsCorrect == true && m_bWin == false) {
			m_pProgressionBar.value += Time.deltaTime * m_fSliderSpeed;
		} else if (m_pCubesManagerScript.m_bColorIsCorrect == false && m_bWin == false) {
			m_pProgressionBar.value -= Time.deltaTime * m_fSliderSpeed;
		}

		if (m_pProgressionBar.value == 1) {
			m_bWin = true;
			m_pArchCollider.isTrigger = true;
			m_pGate.SetActive (true);

		}
	}
}
