
using UnityEngine;
using System;

public class platfomAvtoMove : MonoBehaviour
{
    public float Xspeed = 7f;
    [SerializeField] private bool isInRight = false;
    [SerializeField] private bool isMove = false;
    public float distanse = 7f;
    public float maxDist;
    public float minDist;


    private void Start()
    {
        maxDist = transform.position.x + distanse;
        minDist = transform.position.x - distanse;
    }
    private void Update()
    {
        if (isMove)
        {
            if (!isInRight)
            {
                RightMove();
            }
            else if(isInRight)
            {
                LeftMove();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
      if (col.gameObject.tag == "Player")
      {
            isMove = true;
           
      }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            isMove = false;

        }
    }
    void RightMove()
    {
        transform.position = new Vector2(transform.position.x + Xspeed * Time.deltaTime, transform.position.y);
        if (transform.position.x > maxDist)
        {
            isMove = false ;
            isInRight = true;
        }
    }
    void LeftMove()
    {
        transform.position = new Vector2(transform.position.x - Xspeed * Time.deltaTime, transform.position.y);
        if (transform.position.x <minDist)
        {
            isMove = false;
            isInRight = false;

        }
    }
}
