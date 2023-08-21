using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public float damage = 3;
    public Collider2D swordCollider;


    Vector2 rightAttackOfset;
   

    private void Start()
    {
       
        rightAttackOfset = transform.position;
    }
    public void AttackRight()
    {
        print("Attack Right");
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOfset;
    }

    

    public void AttackLeft()
    {
        print("Attack Left");
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOfset.x * -1, rightAttackOfset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }
}
