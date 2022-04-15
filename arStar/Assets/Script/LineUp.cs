using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineUp : MonoBehaviour
{
    public GameObject constellation;
    public GameObject spot;
    public List<Vector3> stars;
    public float speed = 0.2f;
    float step;
    int num=0;
    public bool movement = false;
    void Start()
    {
        foreach (Transform child in constellation.transform)
        {
            stars.Add(child.position);
        }
        step = speed * Time.deltaTime;
        spot.transform.position = stars[0];
    }
    
    void Update()
    {
        if (movement)
        {
            spot.transform.position = Vector3.MoveTowards(spot.transform.position, stars[num], step);
            if (spot.transform.position == stars[num] && num < stars.Count)
            {
                num++;
            }
            if (num == stars.Count)
            {
                movement = false;
                //spot.GetComponent<TrailRenderer>().enabled = false;
                num = 0;
            }
        }
    }
    
    public void Line()
    {
        movement = true;
        float step = speed * Time.deltaTime;
        spot.GetComponent<TrailRenderer>().enabled = true;
    }   
}
