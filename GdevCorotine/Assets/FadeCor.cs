﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCor : MonoBehaviour
{
    [SerializeField] private Renderer rend;
    [SerializeField] private float WaitTime = 1.0f;
    [SerializeField] private float fadeSpeed = 0.1f;
    // Update is called once per frame


    private void Start()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        for (float ft = 0f; ft >= 1; ft += fadeSpeed)
        {
            Color c = rend.material.color;
            c.a = ft;
            rend.material.color = c;
            yield return null;
        }
    }
}
