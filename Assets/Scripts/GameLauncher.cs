using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameLauncher : MonoBehaviour
{
    public Transform plane;

    [Range(0.5f, 5f)] 
    public float speed = 1.0f;

    static Vector3 _left = new Vector3(-0.1f, 0, 0);
    static Vector3 _right = new Vector3(0.1f, 0, 0);
    static Vector3 _up = new Vector3(0, 0.1f, 0);
    static Vector3 _down = new Vector3(0, -0.1f, 0);

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (plane == null) return;

        float horizontal = Input.GetAxis("Horizontal");
        if (!horizontal.Equals(0f))
        {
            plane.Translate(horizontal * speed * Vector3.right);
        }
        
        
        float vertical = Input.GetAxis("Vertical");
        if (!vertical.Equals(0f))
        {
            plane.Translate(vertical * speed * Vector3.up);
        }

        return;
        
        if (Input.GetKey(KeyCode.A))
        {
            plane.Translate(_left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            plane.Translate(_right * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            plane.Translate(_up * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            plane.Translate(_down * speed);
        }
    }
}