using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaseOutColor : MonoBehaviour
{
    [SerializeField] private Renderer rend;
    [SerializeField] private float fadeSpeed = 10f;
    // Update is called once per frame

    private void Start()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float t = 0;
        while (t <= 1.0f)
        {
            t += Time.deltaTime / fadeSpeed;
            float easeStep = t / t / t / t / t;
            Color c = rend.material.color;
            c.a = easeStep;
            rend.material.color = c;
            yield return null;
        }
    }
}
