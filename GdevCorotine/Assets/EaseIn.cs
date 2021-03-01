using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaseIn : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private float length = 7;
    void Start()
    {
        StartCoroutine(MoveFromTo(speed));
    }

    IEnumerator MoveFromTo(float speed)
    {
        Vector3 target = transform.position + Vector3.forward * length;
        Vector3 startPosition = transform.position;
        Vector3 direction = target - startPosition;

        float t = 0;

        while (t <= 1)
        {
            t += Time.deltaTime / speed;

            float easeStep = t * t * t;

            transform.position = startPosition + (direction * easeStep);

            yield return null;
        }
        transform.position = target;
    }
}
