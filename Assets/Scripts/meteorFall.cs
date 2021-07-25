using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorFall : MonoBehaviour
{

    float speed = -3f;
    //float rotation;
    // Start is called before the first frame update
    void Start()
    {
        //rotation = Random.Range(-40, 40);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        //transform.Rotate(0f, rotation * Time.deltaTime, 0f);
    }
}
