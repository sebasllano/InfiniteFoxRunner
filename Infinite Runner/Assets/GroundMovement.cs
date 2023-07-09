using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {

        {
            transform.position += Vector3.left * velocidad* Time.deltaTime;
        }

    }
}
