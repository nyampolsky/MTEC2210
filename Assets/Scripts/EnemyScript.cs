using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    private Transform EnemyHolder;
    public float speed = 0.1f;
    public GameObject shot;
    public Text winText;
    public float fireRate = .997f;
    public Text Lose;
    public GameObject enemy1;
    
    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
        Lose.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        EnemyHolder = GetComponent<Transform>();
    }

    // Update is called once per frame
    void MoveEnemy()
    {
        EnemyHolder.position += Vector3.right * speed;
        foreach(Transform enemy in EnemyHolder)
        {
            if(enemy.position.x < -10.5 || enemy.position.x > 10.5)
            {
                speed = -speed;
                EnemyHolder.position += Vector3.down * 0.5f;
                return;


            }



        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "lose")
        {

            Lose.enabled = true;
            Destroy(enemy1);
            

        }
    }
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {

            SceneManager.LoadScene(0);




        }
        if(EnemyHolder.childCount == 0)
        {

            winText.enabled = true;


        }
    }
}
