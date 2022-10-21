using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMoveX : MonoBehaviour
{
    public float distanse;
    public float speed;
    private float maxDist;
    private float minDist;
    private bool moveRight;
    private void Start()
    {
        maxDist = transform.position.x + distanse;
        minDist = transform.position.x - distanse;
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > maxDist)
        {
            moveRight = false;
        }
        else if(transform.position.x < minDist)
        {
            moveRight = true;
        }
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
