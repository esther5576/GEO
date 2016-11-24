using UnityEngine;
using System.Collections;

public class MenuVariables 
{
	#region Panel Start App
	public static UIPanel panelStartApp; 
	public static UISprite panelStartAppMap;
	public static UISprite panelStartAppAppName; 
	public static UISprite panelStartAppLoupe; 
	public static UISprite panelStartAppLoupeManche; 
	public static UISprite panelStartAppLoupeElements;
	#endregion

	#region Panel General App
	public static UIPanel panelGeneral; 
	public static UISprite panelGeneralTopCorner; 
	#endregion

	#region Panel Principal App
	public static UIPanel panelPrincipalApp; 
	public static UISprite panelPrincipalAppNouvellesMissions; 
	public static UISprite panelPrincipalAppMissionsEnCours; 
	public static UIButton panelPrincipalAppTakeJobButton; 
	public static UIButton panelPrincipalAppMissionsEnCoursButton; 
	public static UIButton panelPrincipalAppNouvellesMissionsButton; 
	#endregion

	public static void InitVariables()
	{
		#region Panel Start App
		panelStartApp = GameObject.Find ("UI Root/PanelStartApp").GetComponent<UIPanel>();
		panelStartAppMap = GameObject.Find ("UI Root/PanelStartApp/Map").GetComponent<UISprite>();
		panelStartAppAppName = GameObject.Find ("UI Root/PanelStartApp/AppName").GetComponent<UISprite>();
		panelStartAppLoupe = GameObject.Find ("UI Root/PanelStartApp/Loupe").GetComponent<UISprite>();
		panelStartAppLoupeManche = GameObject.Find ("UI Root/PanelStartApp/LoupeManche").GetComponent<UISprite>();
		panelStartAppLoupeElements = GameObject.Find ("UI Root/PanelStartApp/LoupeElements").GetComponent<UISprite>();
		#endregion

		#region Panel General App
		panelGeneral = GameObject.Find ("UI Root/GeneralPanel").GetComponent<UIPanel>();
		panelGeneralTopCorner = GameObject.Find ("UI Root/GeneralPanel/TopCorner").GetComponent<UISprite>();
		#endregion

		#region Panel Principal App
		panelPrincipalApp = GameObject.Find ("UI Root/PanelPrincipalApp").GetComponent<UIPanel>();
		panelPrincipalAppNouvellesMissions = GameObject.Find ("UI Root/PanelPrincipalApp/NouvellesMissions").GetComponent<UISprite>();
		panelPrincipalAppMissionsEnCours = GameObject.Find ("UI Root/PanelPrincipalApp/MissionsEnCours").GetComponent<UISprite>();
		panelPrincipalAppTakeJobButton = GameObject.Find ("UI Root/PanelPrincipalApp/TakeJobButton").GetComponent<UIButton>();
		panelPrincipalAppMissionsEnCoursButton = GameObject.Find ("UI Root/PanelPrincipalApp/MissionsEnCoursButton").GetComponent<UIButton>(); 
		panelPrincipalAppNouvellesMissionsButton = GameObject.Find ("UI Root/PanelPrincipalApp/NouvellesMissionsButton").GetComponent<UIButton>(); 
		#endregion
	}
}
