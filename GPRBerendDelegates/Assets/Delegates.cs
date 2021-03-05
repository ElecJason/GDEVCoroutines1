﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    private Action _currentState;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = Idle;
    }

    // Update is called once per frame
    void Update()
    {
        _currentState();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _currentState = Idle;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _currentState = Walking;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _currentState = Running;
        }
    }

    private void Idle()
    {
        Debug.Log("ik sta niks te doen");
    }

    private void Walking()
    {
        Debug.Log("Kijk mij, ik loop");
    }

    private void Running()
    {
        Debug.Log("Lekker rennen");
    }


}
