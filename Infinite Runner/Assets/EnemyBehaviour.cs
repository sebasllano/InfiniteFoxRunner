using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>(); 
        rb2d = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        rb2d.velocity = Vector2.left * (speed + gm.speedMultiplier);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trigger"))
        {

            Destroy(gameObject);

        }



    }



}
