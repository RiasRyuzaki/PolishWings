using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shipMove : MonoBehaviour
{

    public float speed = 10f;
    //public GameObject bullet;
    //public float bulletThreshold = 0.3f;
    float elapsedTime = 0;
    public shipGame control;

    private float xMax = 3f;
    private float xMin = -3f;

    public AudioSource source;
    public AudioClip fireSound;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        transform.Translate(Input.acceleration.x * speed * Time.deltaTime, 0f, 0f);
        transform.position = new Vector3((Mathf.Clamp(transform.position.x, xMin, xMax)), transform.position.y, transform.position.z);

        /*if (Input.GetButtonDown("Jump") || Input.touches.Length >0)
        {
            if(elapsedTime > bulletThreshold)
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1.2f, -6f), Quaternion.identity);
                source.Play();
                elapsedTime = 0f;
            }

            //source.PlayOneShot(fireSound);
            
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        SceneManager.LoadScene("GameOver");
    }
}
