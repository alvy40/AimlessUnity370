﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.transform.position.y, transform.position.z);  
    }
}
