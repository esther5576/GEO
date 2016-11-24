using UnityEngine;
using System.Collections;

public class MenuVariables 
{
	public static UIPanel panelStartApp; 
	public static UISprite panelStartAppMap; 
	public static UISprite panelStartAppTopCorner; 
	public static UISprite panelStartAppAppName; 
	public static UISprite panelStartAppLoupe; 
	public static UISprite panelStartAppLoupeManche; 
	public static UISprite panelStartAppLoupeElements;

	public static void InitVariables()
	{
		panelStartApp = GameObject.Find ("UI Root/PanelStartApp").GetComponent<UIPanel>();
		panelStartAppMap = GameObject.Find ("UI Root/PanelStartApp/Map").GetComponent<UISprite>();
		panelStartAppTopCorner = GameObject.Find ("UI Root/GeneralPanel/Top Corner").GetComponent<UISprite>();
		panelStartAppAppName = GameObject.Find ("UI Root/PanelStartApp/AppName").GetComponent<UISprite>();
		panelStartAppLoupe = GameObject.Find ("UI Root/PanelStartApp/Loupe").GetComponent<UISprite>();
		panelStartAppLoupeManche = GameObject.Find ("UI Root/PanelStartApp/LoupeManche").GetComponent<UISprite>();
		panelStartAppLoupeElements = GameObject.Find ("UI Root/PanelStartApp/LoupeElements").GetComponent<UISprite>();
	}
}
