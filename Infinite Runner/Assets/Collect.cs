using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Collect : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float speed;

    public GameObject Collective;
    public int puntos;
   



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        puntos = 0;
    }

    void Update()
    {
        rb2d.velocity = Vector2.left * speed;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){


            Destroy(Collective);
            puntos += 100;
            

        }
    }
}
