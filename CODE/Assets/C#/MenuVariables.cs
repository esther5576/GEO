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
	public static UIButton panelPrincipalAppGPSButton; 
	public static UIButton panelPrincipalAppSMSButton; 
	public static UIButton panelPrincipalAppGaleryButton; 
	#endregion

	#region Panel Textos App
	public static UIPanel panelTextoApp;
	public static UISprite panelTextoAppBackground;
	public static UISprite panelTextoAppTopCorner;
	#endregion

	#region Panel Galerie App
	public static UIPanel panelGalerieApp;
	public static UISprite panelGalerieAppBackground;
	public static UISprite panelGalerieAppTopCorner;
	#endregion

	#region Panel Geo App
	public static UIPanel panelGeoApp;
	public static UISprite panelGeoAppTopCorner;
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
		panelPrincipalAppGPSButton = GameObject.Find("UI Root/PanelPrincipalApp/GPSButton").GetComponent<UIButton>(); 
		panelPrincipalAppSMSButton = GameObject.Find("UI Root/PanelPrincipalApp/SMSButton").GetComponent<UIButton>();  
		panelPrincipalAppGaleryButton = GameObject.Find("UI Root/PanelPrincipalApp/GaleryButton").GetComponent<UIButton>();  
		#endregion

		#region Panel Textos App
		panelTextoApp = GameObject.Find("UI Root/PanelTextos").GetComponent<UIPanel>(); 
		panelTextoAppBackground = GameObject.Find("UI Root/PanelTextos/Background").GetComponent<UISprite>();  
		panelTextoAppTopCorner = GameObject.Find("UI Root/PanelTextos/TopCorner").GetComponent<UISprite>();  
		#endregion

		#region Panel Galerie App
		panelGalerieApp = GameObject.Find("UI Root/PanelGalerie").GetComponent<UIPanel>(); 
		panelGalerieAppBackground = GameObject.Find("UI Root/PanelGalerie/Background").GetComponent<UISprite>(); 
		panelGalerieAppTopCorner = GameObject.Find("UI Root/PanelGalerie/TopCorner").GetComponent<UISprite>(); 
		#endregion

		#region Panel Geo App
		panelGeoApp = GameObject.Find("UI Root/PanelGeo").GetComponent<UIPanel>(); 
		panelGeoAppTopCorner = GameObject.Find("UI Root/PanelGeo/TopCorner").GetComponent<UISprite>();
		#endregion
	}
}
