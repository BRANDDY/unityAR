using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraContrller : MonoBehaviour
{
    WebCamTexture tex; //live video input rander
    public RawImage display;
    int currentCamIndex;

    public void SwapCam_clicked()
    {
        if (WebCamTexture.devices.Length>0)// make sure already have cameras connect
        {
            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;
        }
    }

    public void StarStopCam_Clicked()
    {
        if (tex != null)
        {
            StopWebCam();

        }
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;
            tex.Play();
        }
    }

    private void StopWebCam()
    {
        display.texture = null;
        tex.Stop();
        tex = null;
    }

}
