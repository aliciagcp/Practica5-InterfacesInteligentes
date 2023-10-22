using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeEvent : MonoBehaviour
{
    public GameObject ball;
    public float launchForce = 10f;

    public void Update() 
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
        
            if (touch.phase == TouchPhase.Began)
            {
                ball.transform.position = transform.position + transform.forward * 2.5f;
                ball.GetComponent<Rigidbody>().velocity = transform.forward * launchForce;
            }
        }
    }
}