using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaCra : MonoBehaviour
{
    private const float LowPassFilterFactor = 0.2f;
    public float rotationSpeed = 20f;
    private Quaternion targetRotation;
    float targetY = 0f;
    float targetX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;//陀螺仪功能为true
        //Vector3 rotationVelocity = Input.gyro.rotationRate;//陀螺仪旋转速度
        //Vector3 rotationVelocity2 = Input.gyro.rotationRateUnbiased;//更精确值
        Input.gyro.updateInterval = 0.1f; //陀螺仪检查时间（更新速度）s
        //targetRotation = transform.identify
    }

    // Update is called once per frame
    void Update()
    {
        //targetRotation = new Quaternion(-Input.gyro.attitude.x, -Input.gyro.attitude.y, 0, Input.gyro.attitude.w);
        //横屏
        targetRotation = new Quaternion(-Input.gyro.attitude.y, -Input.gyro.attitude.z, Input.gyro.attitude.x, Input.gyro.attitude.w) * Quaternion.Euler(90, 90, 0);
        //竖屏
        //targetRotation = new Quaternion(Input.gyro.attitude.y, Input.gyro.attitude.x, Input.gyro.attitude.z, Input.gyro.attitude.w) * Quaternion.Euler(-90,0,0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, LowPassFilterFactor);
   
        /*
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
        }*/
    }
  
}
