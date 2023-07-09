using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemigo1;
    public GameObject[] enemigo2;
    public GameObject[] pizza;

    public GameObject spawnObject;
    public GameObject spawnObject2;
    public GameObject spawnObject3;
    public float temporizador;
    public float tiempoEntreSpawns;

    public float temporizador2;
    public float tiempoEntreSpawns2;

    public float temporizador3;
    public float tiempoEntreSpawns3;

    public float speedMultiplier;

    public float distancia;

    public TextMeshProUGUI distanciaUI;

    

    

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanciaUI.text = distancia.ToString();



        speedMultiplier += Time.deltaTime * 0.1f;


        temporizador += Time.deltaTime;

        distancia += Time.deltaTime * 0.8f;

        if(temporizador > tiempoEntreSpawns)
        {
            temporizador = 0;
            int randNums = Random.Range(0, 1);
            Instantiate(spawnObject, enemigo1[randNums]. transform.position, Quaternion.identity);
            // Instantiate(spawnObject3, enemigo2[randNums].transform.position, Quaternion.identity);
            //Instantiate(spawnObject2, pizza[randNums].transform.position, Quaternion.identity);
           
        }

        temporizador2 += Time.deltaTime;

        if (temporizador2 > tiempoEntreSpawns2)
        {
            temporizador2 = 0;
            int randNums = Random.Range(0, 1);
          
            Instantiate(spawnObject3, enemigo2[randNums].transform.position, Quaternion.identity);
            
        }

        temporizador3 += Time.deltaTime;

        if (temporizador3 > tiempoEntreSpawns3)
        {
            temporizador3 = 0;
            int randNums = Random.Range(0, 1);

            Instantiate(spawnObject2, pizza[randNums].transform.position, Quaternion.identity);

        }
    }
}
