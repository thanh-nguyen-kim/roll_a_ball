using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This scripts make the camera follow the ball
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float smoothSpeed = 0.2f;
    [SerializeField] private Vector3 offset = new Vector3(0, 0, -1);
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed);
    }
}
