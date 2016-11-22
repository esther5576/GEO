using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	//Camera de la scene
	Camera m_pCamera;

	//Speed de déplacemend de la camera
	public float m_fCameraSpeed = 100f;

	//Variable touch
	Touch m_pTouch;

	//Temps de touch
	float m_fTouchDuration;

	//Confirmation du double touch
	bool m_bIsDoubleTouch = false;

	void Awake ()
	{
		m_pCamera = Camera.main;
	}

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{

		CheckIsADoubleTap ();

	}

	void CheckIsADoubleTap ()
	{

		if (Input.touchCount > 1) {
			m_bIsDoubleTouch = true;
			m_fTouchDuration += Time.deltaTime;
			m_pTouch = Input.GetTouch (0);

			if (m_pTouch.phase == TouchPhase.Ended && m_fTouchDuration < 0.2f)
				StartCoroutine ("ApplyTapBehavior");
		} else if (Input.touchCount == 1) { 
			m_fTouchDuration += Time.deltaTime;
			m_pTouch = Input.GetTouch (0);
			m_bIsDoubleTouch = false;

			if (m_pTouch.phase == TouchPhase.Ended && m_fTouchDuration < 0.2f)
				StartCoroutine ("ApplyTapBehavior");
		} else
			m_fTouchDuration = 0.0f;
	}

	void MoveForward (bool bForward)
	{
		if (bForward)
			m_pCamera.transform.Translate (-Vector3.forward * Time.deltaTime * m_fCameraSpeed);
		else
			m_pCamera.transform.Translate (Vector3.forward * Time.deltaTime * m_fCameraSpeed);
	}

	IEnumerator ApplyTapBehavior ()
	{
		yield return new WaitForSeconds (0.3f);
		if (m_pTouch.tapCount == 1)
			Debug.Log ("Single");
		else if (m_pTouch.tapCount == 2) {
			MoveForward (m_bIsDoubleTouch);
			StopCoroutine ("ApplyTapBehavior");
			Debug.Log ("Double");
		}
	}
}
