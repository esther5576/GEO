using UnityEngine;
using System.Collections;

public class PinchTouchZoom : MonoBehaviour
{
    public float fPerspectiveZoomSpeed = 0.5f;
    public float fOrthoZoomSpeed = 0.5f;

    void Update()
    {

        if (Input.touchCount == 2)
        {

            Touch pTouchZero = Input.GetTouch(0);
            Touch pTouchOne = Input.GetTouch(1);

            Vector2 vTouchZeroPrevPos = pTouchZero.position - pTouchZero.deltaPosition;
            Vector2 vTouchOnePrevPos = pTouchOne.position - pTouchOne.deltaPosition;

            float fPrevTouchDeltaMag = (vTouchZeroPrevPos - vTouchOnePrevPos).magnitude;
            float fTouchDeltaMag = (pTouchZero.position - pTouchOne.position).magnitude;

            float fDeltaMagnitudeDiff = fPrevTouchDeltaMag - fTouchDeltaMag;

            if (GetComponent<Camera>().orthographic)
            {
                GetComponent<Camera>().orthographicSize += fDeltaMagnitudeDiff * fOrthoZoomSpeed;

                GetComponent<Camera>().orthographicSize = Mathf.Max(GetComponent<Camera>().orthographicSize, 0.1f);
            }
            else
            {
                GetComponent<Camera>().fieldOfView += fDeltaMagnitudeDiff * fPerspectiveZoomSpeed;

                GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, 0.1f, 179.9f);
            }
        }
    }
}
