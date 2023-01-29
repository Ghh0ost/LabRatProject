using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class spriteFollow : MonoBehaviour
{
    public GameObject remi;

    public float smoothing;

    private Vector3 initialPosition;
    private Vector3 targetPosition;

    void Start()
    {
        initialPosition = remi.transform.position;
    }
    void Update()
    {
        targetPosition = new Vector3(transform.position.x + (remi.transform.position.x - initialPosition.x), transform.position.y + (remi.transform.position.y - initialPosition.y), transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

    }
}
