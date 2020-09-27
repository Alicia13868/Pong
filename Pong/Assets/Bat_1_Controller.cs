﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_1_Controller : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.velocity = new Vector2(0f, 10f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.velocity = new Vector2(0f, -10f);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0f, 0f);
        }
    }
}
