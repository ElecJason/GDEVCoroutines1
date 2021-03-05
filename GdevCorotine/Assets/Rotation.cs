using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private float turnAmount = 5;
    void Start()
    {
        StartCoroutine(MoveFromTo(speed));
    }

    IEnumerator MoveFromTo(float speed)
    {
        float t = 0;

        while (t <= 1)
        {
            t += Time.deltaTime / speed;

            float easeStep = t / t / t;

            transform.Rotate(easeStep * turnAmount, 0, 0);

            yield return null;
        }
    }
}