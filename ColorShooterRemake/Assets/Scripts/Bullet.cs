using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Damage = 20f;
    Color colorRend;

    private void Start()
    {
        colorRend = Color.white;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            colorRend = new Color(Random.value, Random.value, Random.value);
            Enemy.rend.material.color = colorRend;
            TakeDamage(Damage);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float _damage)
    {
        Enemy.CurrentHealth -= _damage;
    }
}
