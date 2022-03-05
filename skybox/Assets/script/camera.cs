using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float rotationSpeed = 20f;
    private Quaternion targetRotation;
    float targetY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        targetRotation = Quaternion.identity; //original rotation data
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            targetY += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime; //rota level
            targetRotation.eulerAngles = new Vector3(0, Mathf.Repeat(targetY, 360f) + targetY, 0); //get euler Angles
            transform.rotation = targetRotation;
        }
    }
}
