using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject target;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (PlayerAttack.IsAttacking)
            {
                Destroy(target);
            }
            else
            {
                PlayerHP.HP -= 20;
            }
        }
    }
}
