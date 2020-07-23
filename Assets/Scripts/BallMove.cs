﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D BallRb;

    void Start()
    {
        speed = GameManagement.ballSpeed;

        BallRb = GetComponent<Rigidbody2D>();
        BallRb.isKinematic = false;
        BallRb.AddForce(new Vector2(0, speed));
    }

   
    void Update()
    {
        
    }
}
