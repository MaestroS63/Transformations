using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 5f;

    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}