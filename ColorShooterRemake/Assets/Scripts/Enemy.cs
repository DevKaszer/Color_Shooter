using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public float Speed = 2.5f;
    public float Health = 100f;
    public static float CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = Health;
        Player = GameObject.Find("TurretHolder").GetComponent<Transform>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0f)
        {
            Destroy(gameObject);
        }  
    }

    private void FixedUpdate()
    {
        var TargetPos = new Vector2(Player.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, TargetPos, Speed * Time.deltaTime);
    }
}
