﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenVentManual : MonoBehaviour
{
    // Smoothly open a door
    public float doorOpenAngle = 120.0f; //Set either positive or negative number to open the door inwards or outwards
    public float openSpeed = 2.0f; //Increasing this value will make the door open faster

    bool open = false;
    bool enter = false;

    float defaultRotationAngle;
    float currentRotationAngle;
    float openTime = 0;

    void Start()
    {
        defaultRotationAngle = transform.localEulerAngles.z;
        currentRotationAngle = transform.localEulerAngles.z;
    }

    // Main function
    void Update()
    {
        if(openTime < 1)
        {
            openTime += Time.deltaTime * openSpeed;
        }
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, Mathf.LerpAngle(currentRotationAngle, defaultRotationAngle + (open ? doorOpenAngle : 0), openTime));

        if (Input.GetKeyDown(KeyCode.F) && enter)
        {
            open = !open;
            currentRotationAngle = transform.localEulerAngles.z;
            openTime = 0;
        }
    }

    // Display a simple info message when player is inside the trigger area
    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'F' to open the door");
        }
    }

    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }

    // Deactivate the Main function when Player exit the trigger area
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = false;

            /* if on other side of vent - close behind them
            open = !open;
            currentRotationAngle = transform.localEulerAngles.z;
            openTime = 0;
            */
        }
    }
}
