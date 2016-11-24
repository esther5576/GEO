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
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.position = new Vector3 (460, 186, 0);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.position = new Vector3 (460, 186, 0);


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
		MenuVariables.panelPrincipalAppMissionsEnCoursButton.transform.DOLocalMove (new Vector3 (0, 186, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
		MenuVariables.panelPrincipalAppNouvellesMissionsButton.transform.DOLocalMove (new Vector3 (0, 186, 0), 0.6f, false).SetEase (Ease.OutExpo).SetDelay(1.85f);
	}
}
