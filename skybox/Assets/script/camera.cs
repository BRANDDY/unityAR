using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float rotationSpeed = 20f;
    private Quaternion targetRotation;
    float targetY = 0f;
    float targetX = 0f;
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
            targetX -= Input.GetAxis("Mouse Y") * 10 * Time.deltaTime;
            if (targetX > 20) //rota X will not over 20 degree
            {
                targetX = 20;
            } else if (targetX < -20)
            {
                targetX = -20;
            }
            targetRotation.eulerAngles = new Vector3(targetX, Mathf.Repeat(targetY, 360f), 0); //get euler Angles
            transform.rotation = targetRotation;
        }
    }
}
