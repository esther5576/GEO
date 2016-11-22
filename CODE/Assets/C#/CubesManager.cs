using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubesManager : MonoBehaviour
{
	//texture de se que la camera voit
	WebCamTexture m_pWebcamTex;
	//Tableau de couleurs
	public Color32[] m_aColorArray;

	//Liste de tous les cubes dans la scene
	public List<GameObject> m_aCubes = new List<GameObject> ();
	//Liste de tous les composants Render qui se trouvent sur chaque cube
	public List<Renderer> m_aCubesRenderers = new List<Renderer> ();

	//Material visé (lla couleur que l'on veut obtenir
	public Material m_pArchMat;

	//Bool si la couleur est correcte
	public bool m_bColorIsCorrect;

	//Script qui régit les régles du jeu
	public PuzzleRules m_pPuzzleRulesScript;

	//Compteur pour lancer une fois une fonction dans l'update
	public int m_iCount = 0;

	void Awake ()
	{
		m_aCubes.AddRange (GameObject.FindGameObjectsWithTag ("ColoredCubes"));
		for (int i = 0; i < m_aCubes.Count; i++) {
			m_aCubesRenderers.Add (m_aCubes [i].GetComponent<Renderer> ());
		}

		m_pPuzzleRulesScript = GameObject.Find ("PuzzleManager").GetComponent<PuzzleRules> ();
	}

	// Use this for initialization
	void Start ()
	{
		//Initialisation de la caméra du téléphone
		m_pWebcamTex = new WebCamTexture ();
		m_pWebcamTex.Play ();
		m_aColorArray = new Color32[m_pWebcamTex.width * m_pWebcamTex.height];
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (m_pPuzzleRulesScript.m_bWin == false) {
			ApplyCamColor ();
		} 
		if (m_pPuzzleRulesScript.m_bWin == true && m_iCount == 0) {
			m_iCount++;
			foreach (Renderer pRenderer in m_aCubesRenderers) {
				pRenderer.material.color = m_pArchMat.color;
			}
		}
			

		if (GetColorDiff () <= 0.3f) {
			//On exclut les gris car ils faussent le calcul
			if (GetAverageColor ().r == GetAverageColor ().g && GetAverageColor ().g == GetAverageColor ().b) {
				m_bColorIsCorrect = false;
			} else {
				m_bColorIsCorrect = true;
			}
		} else {
			//faire redescendre la barre de progression
			m_bColorIsCorrect = false;
		}
	}

	void ApplyCamColor ()
	{
		Color32 pAverageColor = GetAverageColor ();

		foreach (Renderer pRenderer in m_aCubesRenderers) {
			pRenderer.material.color = pAverageColor;
		}

	}

	float GetColorDiff ()
	{
		return (Mathf.Abs (m_pArchMat.color.r - GetAverageColor ().r) + Mathf.Abs (m_pArchMat.color.g - GetAverageColor ().g) + Mathf.Abs (m_pArchMat.color.b - GetAverageColor ().b)) / 765;
	}


	Color32 GetAverageColor ()
	{
		m_pWebcamTex.GetPixels32 (m_aColorArray);
		int iTotal = m_aColorArray.Length;

		float fR = 0f;
		float fG = 0f;
		float fB = 0f;

		for (int i = 0; i < iTotal; i++) {
			fR += m_aColorArray [i].r;
			fG += m_aColorArray [i].g;
			fB += m_aColorArray [i].b;
		}
		return new Color32 ((byte)(fR / iTotal), (byte)(fG / iTotal), (byte)(fB / iTotal), 0);
	}
		
}
