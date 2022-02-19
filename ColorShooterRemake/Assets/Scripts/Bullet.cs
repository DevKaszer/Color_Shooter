using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Damage = 20f;

    private void Start()
    {        
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(Damage);
        Destroy(gameObject);
    }

    public void TakeDamage(float _damage)
    {
        Enemy.CurrentHealth -= _damage;
    }
}
