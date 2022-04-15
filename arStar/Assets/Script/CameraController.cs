using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const float LowPassFilterFactor = 0.2f;
    public float rotationSpeed = 20f;
    private Quaternion targetRotation;
    float targetY = 0f;
    float targetX = 0f;

    void Start()
    {
        Input.gyro.enabled = true;
        //Vector3 rotationVelocity = Input.gyro.rotationRate;
        //Vector3 rotationVelocity2 = Input.gyro.rotationRateUnbiased;
        Input.gyro.updateInterval = 0.1f;
        //targetRotation = transform.identify
    }
    
    void Update()
    {
        LineupTrigger();
        CameraRota();
    }

    public void CameraRota()
    {
        //targetRotation = new Quaternion(-Input.gyro.attitude.x, -Input.gyro.attitude.y, 0, Input.gyro.attitude.w);
        targetRotation = new Quaternion(-Input.gyro.attitude.y, -Input.gyro.attitude.z, Input.gyro.attitude.x, Input.gyro.attitude.w) * Quaternion.Euler(90, 90, 0);
        //targetRotation = new Quaternion(Input.gyro.attitude.y, Input.gyro.attitude.x, Input.gyro.attitude.z, Input.gyro.attitude.w) * Quaternion.Euler(-90,0,0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, LowPassFilterFactor);


        if (Input.GetMouseButton(0))
        {
            targetY += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime; //rota level
            targetX -= Input.GetAxis("Mouse Y") * 10 * Time.deltaTime;
            if (targetX > 20) //rota X will not over 20 degree
            {
                targetX = 20;
            }
            else if (targetX < -20)
            {
                targetX = -20;
            }
            targetRotation.eulerAngles = new Vector3(targetX, Mathf.Repeat(targetY, 360f), 0); //get euler Angles
            transform.rotation = targetRotation;
        }
    }

    public void LineupTrigger()
    {
        float angle = transform.rotation.y;
        if (angle < 0.14f && angle > 0)
        {
            GameObject.Find("cons1").GetComponent<LineUp>().Line();
        }
        if (angle < 0.24f && angle > 0.15)
        {
            GameObject.Find("cons2").GetComponent<LineUp>().Line();
        }
        if (angle < 0.69f && angle > 0.49)
        {
            GameObject.Find("cons4").GetComponent<LineUp>().Line();
        }
        if (angle < 0.99f && angle > 0.97)
        {
            GameObject.Find("cons3").GetComponent<LineUp>().Line();
        }
        if (angle < 0.76f && angle > 0.59)
        {
            GameObject.Find("cons5").GetComponent<LineUp>().Line();
        }
        //Debug.Log(transform.rotation.y);
    }

}
