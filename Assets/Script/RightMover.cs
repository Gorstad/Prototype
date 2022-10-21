using UnityEngine.SceneManagement;
using UnityEngine;

public class RightMover : MonoBehaviour
{


    private Rigidbody2D rb;
    public float speed = 5;
    [SerializeField] private float maxSpeed;
    public float jumpForce;
    public static bool CanJump = true;
    [SerializeField] private float boostJump;

    //�������� �� �������� ��������� �� �������� �� �����
    private bool IsGrounded;
    public Transform fitPos;
    public float CheckRadius;
    public LayerMask WhatIsGround;

    //���������� ���������� (���� ��) ��������� Rigidbody2D
    private void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }


    //��������� ��������� ���������
    void FixedUpdate()
    {
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);
    }

    //��������� ��������� ������� ��� ������� �� UpArrow
    private void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(fitPos.position, CheckRadius, WhatIsGround);
        if (IsGrounded == true && Input.GetKeyDown(KeyCode.UpArrow) && CanJump)
        {
            SimpleJump();
        }
    } 
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "boost")
        {
            rb.AddForce(Vector2.up * jumpForce * boostJump);
        }
    }   
       private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "slow")
        {
           speed = 2f;
        }
        else
        {
            speed = maxSpeed;
        }
        if (col.gameObject.tag == "moveplatform" && Input.GetKeyDown(KeyCode.UpArrow))
        {
         SimpleJump();
        }
    }
    private void SimpleJump()
    {
      rb.velocity = Vector2.up * jumpForce;
    }
}
