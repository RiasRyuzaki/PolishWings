using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public GameObject enemy;
    public GameObject bulletClone;
    float speed = -3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);

        FireEnemyBullet();
    }
    void FireEnemyBullet()
    {
        if (Random.Range(0f, 500f) < 1)
        {
            bulletClone = Instantiate(bullet, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.6f, -6f), enemy.transform.rotation) as GameObject;
        }
    }
}
