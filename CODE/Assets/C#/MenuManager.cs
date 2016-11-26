using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MenuManager : MonoBehaviour 
{
	private bool _rotateLogo;

	// Use this for initialization
	void Awake () 
	{
		MenuVariables.InitVariables ();
		StartApp ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		#region Start Panel Region
		if (_rotateLogo) 
		{
			MenuVariables.panelStartAppLoupeElements.transform.localEulerAngles += new Vector3 (0, 0, 15) * Time.deltaTime;

			if (Input.GetMouseButtonDown (0)) 
			{
				Debug.Log ("Close App");

				CloseStartMenu ();
			}
		}
		#endregion
	}

	void StartApp()
	{
		MenuVariables.panelStartAppAppName.alpha = 0;
		MenuVariables.panelStartAppLoupeElements.alpha = 0;
		MenuVariables.panelStartAppLoupeElements.transform.localScale = Vector3.zero;
		MenuVariables.panelStartAppLoupe.transform.localPosition = new Vector3 (410, -610, 0);
		MenuVariables.panelStartAppLoupeManche.transform.localPosition = new Vector3 (410, -610, 0);


		MenuVariables.panelGeneralTopCorner.transform.localPosition = new Vector3 (0, 40, 0);


		MenuVariables.panelPrincipalAppMissionsEnCours.transform.position = new Vector3 (460, -9, 0);
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.position = new Vector3 (460, -9, 0);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.position = new Vector3 (460, -9, 0);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.position =  new Vector3 (460, -9, 0);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.position =  new Vector3 (460, -9, 0);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.isEnabled = false;
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.isEnabled = false;
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.disabledSprite = "_boutonNouvelleMissionGrise";
		MenuVariables.panelPrincipalAppGPSButton.gameObject.SetActive (false); 
		MenuVariables.panelPrincipalAppSMSButton.gameObject.SetActive (false); 
		MenuVariables.panelPrincipalAppGaleryButton.gameObject.SetActive (false); 

		MenuVariables.panelTextoAppBackground.transform.localPosition = new Vector3 (490, -9, 0);
		MenuVariables.panelTextoAppTopCorner.transform.localPosition = new Vector3 (490, -9, 0);

		MenuVariables.panelGeoAppTopCorner.transform.localPosition = new Vector3 (0, 880, 0);

		MenuVariables.panelGalerieAppBackground.transform.localPosition = new Vector3 (0, -880, 0);
		MenuVariables.panelGalerieAppTopCorner.transform.localPosition = new Vector3 (0, -880, 0);

		StartTweens ();
	}

	void StartTweens ()
	{
		MenuVariables.panelGeneralTopCorner.transform.DOLocalMove (new Vector3 (0, -10, 0), 0.75f, false).SetEase (Ease.OutExpo);

		MenuVariables.panelStartAppLoupe.transform.DOLocalMove (new Vector3 (0, 0, 0), 0.3f, false).SetEase (Ease.OutExpo).SetDelay(0.55f);
		MenuVariables.panelStartAppLoupeManche.transform.DOLocalMove (new Vector3 (0, 0, 0), 0.3f, false).SetEase (Ease.OutExpo).SetDelay(0.55f);

		MenuVariables.panelStartAppLoupeElements.transform.DOScale (Vector3.one * 1.1f, 0.5f).SetDelay (0.85f).SetEase (Ease.InOutFlash);
		MenuVariables.panelStartAppLoupeElements.transform.DOScale (Vector3.one * 1f, 0.25f).SetDelay (1.35f).SetEase (Ease.OutExpo);
		DOTween.ToAlpha (() => MenuVariables.panelStartAppLoupeElements.color, x => MenuVariables.panelStartAppLoupeElements.color = x, 1, 0.5f).SetDelay (0.85f);
	
		DOTween.ToAlpha (() => MenuVariables.panelStartAppAppName.color, x => MenuVariables.panelStartAppAppName.color = x, 1, 0.5f).SetDelay (1.6f).OnComplete(ChangeBoolRotateLogo);

		MenuVariables.panelStartAppLoupeManche.transform.DOLocalMove (new Vector3 (410, -610, 0), 0.3f, false).SetEase (Ease.InExpo).SetDelay (1.85f);
	}

	void ChangeBoolRotateLogo()
	{
		_rotateLogo = !_rotateLogo;
	}

	void CloseStartMenu()
	{
		ChangeBoolRotateLogo ();

		DOTween.ToAlpha (() => MenuVariables.panelStartAppAppName.color, x => MenuVariables.panelStartAppAppName.color = x, 0, 0.5f);

		MenuVariables.panelStartAppLoupeElements.transform.DOScale (Vector3.one * 1.1f, 0.25f).SetDelay (0.5f).SetEase (Ease.OutFlash);
		MenuVariables.panelStartAppLoupeElements.transform.DOScale (Vector3.one * 0f, 0.5f).SetDelay (0.75f).SetEase (Ease.OutExpo);
		DOTween.ToAlpha (() => MenuVariables.panelStartAppLoupeElements.color, x => MenuVariables.panelStartAppLoupeElements.color = x, 0, 0.5f).SetDelay (1.05f);

		MenuVariables.panelStartAppLoupe.transform.DOLocalMove (new Vector3 (0, 100, 0), 0.25f, false).SetEase (Ease.OutExpo).SetDelay(1.25f);
		MenuVariables.panelStartAppLoupe.transform.DOLocalMove (new Vector3 (0, -900, 0), 0.6f, false).SetEase (Ease.InExpo).SetDelay(1.5f);

		MenuVariables.panelStartAppMap.transform.DOLocalMove (new Vector3 (-500, 0, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(2f);

		StartMenuPrincipal ();
	}

	void StartMenuPrincipal()
	{
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMove (new Vector3 (0, -9, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMove (new Vector3 (0, -9, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMove (new Vector3 (0, -9, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMove (new Vector3 (0, -9, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMove (new Vector3 (0, -9, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
	}

	public void TakeParisJob()
	{
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.disabledSprite = "_boutonNouvelleMission";

		OpenMissionEnCours ();
	}

	public void OpenNouvellesMissions()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.alpha = 1;
		MenuVariables.panelPrincipalAppMissionsEnCours.alpha = 0;

		MenuVariables.panelPrincipalAppTakeJobButton.gameObject.SetActive(true);
		MenuVariables.panelPrincipalAppTakeJobButton.defaultColor = new Color (0.5f, 0.5f, 0.5f);
		MenuVariables.panelPrincipalAppTakeJobButton.isEnabled = false;

		MenuVariables.panelPrincipalAppNouvellesMissionsButton.isEnabled = false;
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.isEnabled = true;

		MenuVariables.panelPrincipalAppGPSButton.gameObject.SetActive (false); 
		MenuVariables.panelPrincipalAppSMSButton.gameObject.SetActive (false); 
		MenuVariables.panelPrincipalAppGaleryButton.gameObject.SetActive (false); 
	}

	public void OpenMissionEnCours()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.alpha = 0;
		MenuVariables.panelPrincipalAppMissionsEnCours.alpha = 1;

		MenuVariables.panelPrincipalAppTakeJobButton.defaultColor = new Color (0.5f, 0.5f, 0.5f);
		MenuVariables.panelPrincipalAppTakeJobButton.gameObject.SetActive(false);
		MenuVariables.panelPrincipalAppTakeJobButton.isEnabled = false;

		MenuVariables.panelPrincipalAppMissionsEnCoursButton.isEnabled = false;
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.isEnabled = true;

		MenuVariables.panelPrincipalAppGPSButton.gameObject.SetActive (true); 
		MenuVariables.panelPrincipalAppSMSButton.gameObject.SetActive (true); 
		MenuVariables.panelPrincipalAppGaleryButton.gameObject.SetActive (true); 
	}

	public void GoToTextos ()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppGPSButton.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppSMSButton.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppGaleryButton.transform.DOLocalMoveX(-490f, 0.6f, false).SetEase (Ease.OutExpo);

		MenuVariables.panelTextoAppBackground.transform.DOLocalMoveX(0, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelTextoAppTopCorner.transform.DOLocalMoveX(0, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
	}

	public void CloseTextos ()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppGPSButton.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppSMSButton.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppGaleryButton.transform.DOLocalMoveX(0f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);

		MenuVariables.panelTextoAppBackground.transform.DOLocalMoveX (490, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelTextoAppTopCorner.transform.DOLocalMoveX (490, 0.6f, false).SetEase (Ease.OutExpo);
	}

	public void GoToMap ()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppGPSButton.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppSMSButton.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppGaleryButton.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);

		MenuVariables.panelGeoAppTopCorner.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
	}

	public void CloseMap()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppGPSButton.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppSMSButton.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppGaleryButton.transform.DOLocalMoveY(-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);

		MenuVariables.panelGeoAppTopCorner.transform.DOLocalMoveY (880, 0.6f, false).SetEase (Ease.OutExpo);
	}

	public void GoToGalery()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppGPSButton.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppSMSButton.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelPrincipalAppGaleryButton.transform.DOLocalMoveY (880f, 0.6f, false).SetEase (Ease.OutExpo);

		MenuVariables.panelGalerieAppBackground.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelGalerieAppTopCorner.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
	}

	public void CloseGalery()
	{
		MenuVariables.panelPrincipalAppNouvellesMissions.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppMissionsEnCours.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppTakeJobButton.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppGPSButton.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppSMSButton.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);
		MenuVariables.panelPrincipalAppGaleryButton.transform.DOLocalMoveY (-9f, 0.6f, false).SetEase (Ease.OutExpo).SetDelay(0.35f);

		MenuVariables.panelGalerieAppBackground.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
		MenuVariables.panelGalerieAppTopCorner.transform.DOLocalMoveY (-880f, 0.6f, false).SetEase (Ease.OutExpo);
	}
}
