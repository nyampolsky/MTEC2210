using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Transform bullet;
    public GameObject Bullet;
    private Transform player;
    public float speed;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;
        if (bullet.position.y >= 10)
        {
            



        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(Bullet);

        }
    }
}
    
