using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public Transform[] coinpo;
    public GameObject coin;
    int coinwait = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coinwait==0)
        {
            Instantiate(coin, coinpo[Random.Range(0, 6)].position, Quaternion.identity);
            coinwait = 100;
        }
        else
        {
            coinwait=coinwait-4;
        }
        
    }
}
