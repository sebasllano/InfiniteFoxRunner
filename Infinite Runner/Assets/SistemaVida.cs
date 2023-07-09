using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SistemaVida : MonoBehaviour
{
    public GameObject[] corazones;
    public int vida;
    private bool muerte;
    public Animator animator;
    public bool IsHurt;
    public GameObject panelFinal;
    public GameObject botonFinal;
    public TextMeshProUGUI textoPuntos;

    public GameManager GameManager;


    // Start is called before the first frame update
    private void Start()
    {
        
        vida = corazones.Length;
    }

    public void Click()
    {
        SceneManager.LoadScene(0);
    }


    // Update is called once per frame
    void Update()
    {
        if (muerte == true) 
        {
            botonFinal.SetActive(true);
            panelFinal.SetActive(true);
            float distance = GameManager.distancia;
            textoPuntos.text = "Distancia Recorrida: " + distance.ToString();

            Time.timeScale = 0f;
            //Debug.Log("Game Over!");
            if (Input.GetKeyDown(KeyCode.R))
            {
                panelFinal.SetActive(true);
                SceneManager.LoadScene(0);
                Time.timeScale = 1f;
            }

            if (!IsHurt)
            {
                
                IsHurt = false;
            }

        }
    }


    //    public void CargaScene()
    //    {
    //        SceneManager.LoadScene("SampleScene");

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            IsHurt = true;
            animator.SetTrigger("Hurt");
          
            Damage(1);


        }

        else
        {
            IsHurt = false;
          
        }

       
    }



    public void Damage(int d)
    {

        if (vida >= 1)
        {
            vida -= d;
            Destroy(corazones[vida].gameObject);
            if (vida < 1)
            {
                muerte = true;
            }

        }

    }


}

