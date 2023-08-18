using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
   
   

    Vector2 rightAttackOfset;
    Collider2D swordCollider;

    private void Start()
    {
        swordCollider = GetComponent<Collider2D>();
        rightAttackOfset = transform.position;
    }
    public void AttackRight()
    {
        print("Attack Right");
        swordCollider.enabled = true;
        transform.position = rightAttackOfset;
    }

    

    public void AttackLeft()
    {
        print("Attack Left");
        swordCollider.enabled = true;
        transform.position = new Vector3(rightAttackOfset.x * -1, rightAttackOfset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

}
