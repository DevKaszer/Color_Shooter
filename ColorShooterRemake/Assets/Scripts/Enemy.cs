using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float Speed = 5f;
    [SerializeField] GameObject Target;

    private void FixedUpdate()
    {
      moveEnemy();
    }

    void moveEnemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position,Speed * Time.deltaTime);
    }

}
