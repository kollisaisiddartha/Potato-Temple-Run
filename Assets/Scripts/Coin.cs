using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("waitforplatform");
    }
    IEnumerator waitforplatform()
    {

        yield return new WaitForSeconds(4f);
        transform.Translate(new Vector3(0, 0, -10f * Time.deltaTime));
        if(transform.position.z<=-20)
        {
            Destroy(gameObject);
        }
    }
}
