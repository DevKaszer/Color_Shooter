using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public float Speed = 2.5f;
    public float Health = 100f;
    public static float CurrentHealth;
    public static SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        CurrentHealth = Health;
        Player = GameObject.Find("TurretHolder").GetComponent<Transform>();        
    }

    void Update()
    {
        if (CurrentHealth <= 0f)
        {
           // Debug.Log("Kill");
            Destroy(gameObject);
        }  
    }

    private void FixedUpdate()
    {
        var TargetPos = new Vector2(Player.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, TargetPos, Speed * Time.deltaTime);
    }
}
