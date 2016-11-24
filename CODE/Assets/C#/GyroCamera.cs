using UnityEngine;
using System.Collections;

public class GyroCamera : MonoBehaviour
{
	public float fInitialYAngle = 0f;
	public float fAppliedGyroYAngle = 0f;
	public float fCalibrationYAngle = 0f;
	public float sensibility = 2.0f;

    void Start ()
	{
		Input.gyro.enabled = true;
		Application.targetFrameRate = 30;
		fInitialYAngle = transform.eulerAngles.y;
	}

	void Update ()
	{
		ApplyGyroRotation ();
		ApplyCalibration ();
	}

	void OnGUI ()
	{
		if (GUILayout.Button ("Calibrate", GUILayout.Width (300), GUILayout.Height (100))) {
			CalibrateYAngle ();
		}

		string _debug;

		_debug = "" + -fCalibrationYAngle * sensibility;

		GUI.Label(new Rect(100, 100, 100, 20), _debug);
	}

	public void CalibrateYAngle ()
	{
		fCalibrationYAngle = fAppliedGyroYAngle - fInitialYAngle; 
	}

	void ApplyGyroRotation ()
	{

		transform.rotation = Input.gyro.attitude;
		transform.Rotate (0f, 0f, 180f, Space.Self);
		transform.Rotate (90f, 0f, 0f, Space.World);
		fAppliedGyroYAngle = transform.eulerAngles.y;

	}

	void ApplyCalibration ()
	{
		transform.Rotate (0f, -fCalibrationYAngle * sensibility, 0f, Space.World);
	}
}
