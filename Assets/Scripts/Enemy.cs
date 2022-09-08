using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 15;
    public static float score = 0;
    public Transform[] wayPoints;
    [SerializeField] private int rdWayP;
    public Rigidbody2D rigidbody;
    private float waitTime=1;
    public float timeChangeMove = 1;
    private void Update()
    {
        System.Random random = new System.Random();
        if (waitTime==timeChangeMove)
        {
            rdWayP = random.Next(0,2);
        }
        waitTime -= Time.deltaTime;
        if (waitTime<=0)
        {
            waitTime = timeChangeMove;
        }
        transform.position = Vector2.MoveTowards(transform.position,wayPoints[rdWayP].position,speed*Time.deltaTime);
    }
}
