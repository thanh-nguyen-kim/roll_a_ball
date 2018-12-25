using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script controll the movement of the ball base on keyboard input
public class BallController : MonoBehaviour
{
    [SerializeField] private Transform ballCollider;
    [SerializeField] private float speed, laneSpeed;
    private Vector3 laneTargetPos = Vector3.zero;
    public bool isAlive = false;
    private void Start()
    {
        isAlive = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            float moveVal = Input.GetAxis("Horizontal");
            if (moveVal != 0)
                laneTargetPos = new Vector3(Mathf.Clamp(laneTargetPos.x + moveVal / 5, -0.75f, 0.75f), 0, 0);
            else
                laneTargetPos = ballCollider.localPosition;
            transform.Translate(transform.forward * Time.deltaTime * speed);
            ballCollider.localPosition = Vector3.MoveTowards(ballCollider.localPosition, laneTargetPos, Time.deltaTime * laneSpeed);
            ballCollider.Rotate(new Vector3(10, 0, 0));
        }
    }
}
