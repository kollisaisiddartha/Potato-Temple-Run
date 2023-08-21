using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform[] enemysp;
    public GameObject enemy;
    int enemywait = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemywait == 0)
        {
            Instantiate(enemy, enemysp[Random.Range(0, 3)].position, Quaternion.identity);
            enemywait = 120;
        }
        else
        {
            enemywait--;
        }
    }
}
