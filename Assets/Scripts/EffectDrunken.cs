using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDrunken : MonoBehaviour
{
    private float _moveSpeed = 5f;
    private float _rotationSpeed = 100f;
    private float _growSpeed = 1f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}