﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCourotine : MonoBehaviour
{
    [SerializeField] private Transform StartPoint;

    [SerializeField] private float speed = 10;
    [SerializeField] private float length = 7;
    void Start()
    {
        StartCoroutine(MoveFromTo(speed));
    }

    IEnumerator MoveFromTo(float speed)
    {
        Vector3 a = transform.position;
        Vector3 b = transform.position + Vector3.forward * length;
        float step = (speed / (a - b).magnitude) * Time.fixedDeltaTime;
        float t = 0;
        while (t <= 1.0f)
        {
            t += step; // Goes from 0 to 1, incrementing by step each time
            transform.position = Vector3.Lerp(a, b, t); // Move objectToMove closer to b
            yield return null;
        }
        transform.position = b;
    }
}
