using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public float spawnThreshold = 100;
    float spawnDecrement = .1f;

    public GameObject meteor;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Random.Range(0, spawnThreshold) <=1)
        {
            Vector3 pos = transform.position;
            Instantiate(meteor, new Vector3(pos.x + Random.Range(-3, 4), pos.y, pos.z), Quaternion.identity);
            Instantiate(enemy, new Vector3(pos.x + Random.Range(-3, 4), pos.y, pos.z), Quaternion.identity);

            spawnThreshold -= spawnDecrement;
            /*if(spawnThreshold <2)
            {
                spawnThreshold = 2;
            }*/
        }
    }
}
