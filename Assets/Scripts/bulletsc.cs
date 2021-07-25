using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsc : MonoBehaviour
{
    float speed = 10f;
    shipGame control;

    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.Find("GameControl").GetComponent<shipGame>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            //shipGame.instance.AddScore();
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("meteor"))
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
