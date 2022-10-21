using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;

    private void Start()
    {
        GetReferences();
        moveSpeed = maxSpeed;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "slow")
        {
            moveSpeed = 2f;
        }
        else
        {
            moveSpeed = maxSpeed;
        }
    }

    private void GetReferences()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
}
