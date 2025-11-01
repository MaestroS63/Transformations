using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increasing : MonoBehaviour
{
    [SerializeField] private float _increasingSpeed;

    private void Update()
    {
        Vector3 currentScale = transform.localScale;
        transform.localScale = currentScale + Vector3.one * _increasingSpeed * Time.deltaTime;
    }
}