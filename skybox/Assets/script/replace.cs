using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replace : MonoBehaviour
{


    float sensS, cutoffS;
    Color colS;

    // Use this for initialization
    void Start()
    {
        sensS = GetComponent<Image>().material.GetFloat("_Sens");
        cutoffS = GetComponent<Image>().material.GetFloat("_Cutoff");
        colS = GetComponent<Image>().material.GetColor("_Color");

        sens = sensS;
        cutoff = cutoffS;

    }

    void Update()
    {

    }

    public float sens, cutoff;
    public string r = "255", g = "255", b = "255";
   
}