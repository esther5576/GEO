using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
 
public class TexturePlane : MonoBehaviour
{
    WebCamTexture back;
    WebCamDevice[] devices;
 
    public bool isFrontCam;
 
    // Use this for initialization
    void Start()
    {
        //Debug.Log (">>>>>>>>>>>>>" + (float)Screen.height / (float)Screen.width + " --- " + Screen.height + " --- " + Screen.width);
 
        //this.transform.localScale = new Vector3 (2.0f * Mathf.Tan(0.5f* Camera.main.fieldOfView * Mathf.Deg2Rad) , 1 , (2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad)) * Screen.width / Screen.height);
        this.transform.localScale = new Vector3(2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad),
            1,
            (2.0f * Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad)) * (3.0f / 4.0f));
 
        //GameObject gg = GameObject.Find ("DebugPanel/LabelDebug");
 
        back = new WebCamTexture();
        back.requestedFPS = 30;
        devices = WebCamTexture.devices;
        if (back != null && devices.Length > 0)
            back.deviceName = devices[0].name;
 
        //gg.GetComponent<UILabel> ().text = ">>  --dimension--" + back.dimension + " --height-- " + back.requestedHeight + " --width-- " + back.requestedWidth;
 
        this.GetComponent<Renderer>().material.mainTexture = back;
 
        if (back.deviceName != "no camera available.")
            back.Play();
    }
 
    void OnDisable()
    {
        back.Stop();
    }
 
    void OnEnable()
    {
        GameObject gg = GameObject.Find("DebugPanel/LabelDebug");
        if (back != null)
            back.Play();
 
        //gg.GetComponent<UILabel> ().text = ">>>>>>>>>>>>>" + devices.Length;
    }
 
    public void SwitchCam()
    {
        if (devices.Length > 1)
        {
            if (!isFrontCam)
            {
                FrontCam();
                isFrontCam = !isFrontCam;
            }
            else
            {
                BackCam();
                isFrontCam = !isFrontCam;
            }
        }
    }
 
    public void FrontCam()
    {
        back.Stop();
 
        this.transform.localEulerAngles = new Vector3(0, 90, 270);
        back.deviceName = devices[1].name;
        this.GetComponent<Renderer>().material.mainTexture = back;
 
        back.Play();
    }
 
    public void BackCam()
    {
        back.Stop();
 
        this.transform.localEulerAngles = new Vector3(0, 270, 90);
        back.deviceName = devices[0].name;
        this.GetComponent<Renderer>().material.mainTexture = back;
 
        back.Play();
    }
}