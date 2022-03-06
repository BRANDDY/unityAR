using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OpenCvSharp;
using OpenCVForUnity;

public class Replace : MonoBehaviour
{
    public RawImage imge;
    private void Start()
    {
        var img = Imgcodecs.imread(Application.streamingAssetsPath + "////",1);
        var dst = new MatchTargetWeightMask(img.cols(), img.rows(), CV_8UC4);
    }
}
