using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public static bool IsAttacking; 

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            IsAttacking = true;
            RightMover.CanJump = false;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            RightMover.CanJump = true;
        }
    }
}
