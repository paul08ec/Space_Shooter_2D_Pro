﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    [SerializeField]
    private int _speed = 8 ;
    
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if(transform.position.y >= 8 )
        {
            Destroy(this.gameObject);
        }

        
    }
}
