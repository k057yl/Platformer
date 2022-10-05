using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveningPlatform : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public float speed;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.parent = transform;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }
    private void Update()
    {
        if(transform.position.y > -2)
        {
            speed = - speed;
        }
        if (transform.position.y < 6)
        {
            speed = -speed;
        }
        Vector3 input = new Vector2(0f, 1f);
        transform.position = transform.position + input * Time.deltaTime * speed;
    }
    void Atack()
    {
        anim.SetTrigger("Atack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        
    }
}
