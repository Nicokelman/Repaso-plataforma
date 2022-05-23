﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float movementSpeed;
    public float limitRight;
    public float limitLeft;
    public bool toRight;
    
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);

        }
        if(transform.position.x > limitRight)
        {
            toRight = false;
        }
        else if(transform.position.x < limitLeft)
        {
            toRight = true;
        }
    }
}
