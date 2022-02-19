using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    float StartTime = 4f;
    float CurrentTime = 0f;
    bool IsTime = false;

    public GameObject[] TypeOfEnemies;

    public Transform[] SpawnPoints;

    void Start()
    {
        CurrentTime = StartTime;      
    }

    void Update()
    {
        CurrentTime -= 1f * Time.deltaTime;

        if (!IsTime && CurrentTime <= 0f)
        {
            CurrentTime = 0;
            EnemyStart();

            IsTime = true;
        }
        else if (IsTime && CurrentTime <= 3f)
        {
            CurrentTime = 4f;
            IsTime = false;
        }
    }

    private void EnemyStart()
    {
        GameObject SpawnEnemy = TypeOfEnemies[Random.Range(0, TypeOfEnemies.Length)];
        Transform SpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
        Instantiate(SpawnEnemy, SpawnPoint.position, Quaternion.identity);
    }
  


}
