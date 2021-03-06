using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{
    public Transform moon;
    public Transform planet1;
    public Transform planet2;
    public float selfSpeed = 5f;
    public float publicSpeedQ = 20f;
    public float publicSpeedL = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moon.Rotate(Vector3.up * Time.deltaTime * selfSpeed, Space.Self);
        moon.RotateAround(Camera.main.transform.position, Vector3.up,Time.deltaTime* publicSpeedL);
        rotation(planet1, moon);
        rotation(planet2, moon);
    }

    void rotation(Transform child, Transform parent)
    {
        child.Rotate(Vector3.up, Space.Self);
        child.RotateAround(parent.position, Vector3.up, Time.deltaTime * publicSpeedQ);
    }
}
