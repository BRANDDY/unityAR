using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phoneConnect : MonoBehaviour
{
    public RawImage img;
    string deviceName;
    public int camIndex = 0;
    private WebCamTexture tex = null;

    private void Update()
    {
        if(tex == null)
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            if (devices.Length == 0)
            {
                return;
            }
            deviceName = devices[0].name;
            tex = new WebCamTexture(WebCamTexture.devices[camIndex].name, Screen.width, Screen.height, 60);
            img.texture = tex;
            tex.Play();
        }
    }




    /*
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Call());
        WebCamDevice[] devices = WebCamTexture.devices;
        deviceName = devices[0].name;
        tex = new WebCamTexture(WebCamTexture.devices[camIndex].name, Screen.width, Screen.height, 60);
        img.texture = tex;
        tex.Play();
    }

    public IEnumerator Call()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (Application.HasUserAuthorization(UserAuthorization.WebCam) && WebCamTexture.devices.Length > 0)
        {
            tex = new WebCamTexture(WebCamTexture.devices[camIndex].name, Screen.height, 60);
            img.texture = tex;
            tex.Play();
            img.rectTransform.localEulerAngles = new Vector3(0, 0, -tex.videoRotationAngle);
        }
    }

    public void SwitchCamera()
    {
        if (WebCamTexture.devices.Length < 1)
        {
            return;
        }
        if (tex != null)
        {
            tex.Stop();
        }
        camIndex++;
        camIndex = camIndex % WebCamTexture.devices.Length;

        tex = new WebCamTexture(WebCamTexture.devices[camIndex].name, Screen.width, Screen.height, 60);
        img.texture = tex;
        tex.Play();
    }*/
}
