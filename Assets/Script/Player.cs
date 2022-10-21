using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour

{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "moveplatform")
        {
            transform.parent = col.transform;
            print("��");
        }
        print(col.gameObject.tag);
    }
    private void Update()
    {
        
        // if ( Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     rb.velocity = Vector2.up * 30;
        // }
    }
}
