using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [Header("JumpSetting")]
    [SerializeField] private float jumpForce;
    [SerializeField] private int MaxCountOfJump;
    private int currentCountOfJump;

    [Header("GroundCheck")]
    [SerializeField] private bool isGround;
    [SerializeField] [Range(0f, 10f)] private float groundRayDistance;
    [SerializeField] private LayerMask groundLayerMask;
    private RaycastHit2D checkGroundRay;

    private void Start()
    {
        currentCountOfJump = MaxCountOfJump;
        GetReferences();
    }

    private void Update()
    {
        checkGroundRay = Physics2D.Raycast(transform.position, -Vector2.up, groundRayDistance, groundLayerMask);
        Debug.DrawRay(transform.position, -Vector2.up * groundRayDistance, Color.red);
        isGround = checkGroundRay;

        if (isGround) currentCountOfJump = MaxCountOfJump;

        if (Input.GetKeyDown(KeyCode.Space) && (isGround || currentCountOfJump > 0))
        {
            rb.AddForce(Vector3.up * jumpForce * 100);
            //transform.Translate(Vector3.up * jumpForce);
            currentCountOfJump--;
        }
        if (Input.GetKeyDown(KeyCode.S) && !isGround)
        {
            transform.Translate(Vector3.up * jumpForce * -1);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "boost")
        {
            rb.AddForce(Vector3.up * jumpForce * 200);
        }
    }

    private void GetReferences()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
}
