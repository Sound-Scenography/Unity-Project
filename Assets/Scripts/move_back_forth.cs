using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class move_back_forth : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    private float xMainPosition = 0.0f;
    public float distancePosition = 5.0f;


    void Start()
    {
        // x position vom objekt wird in var abgespeichert
        xMainPosition = transform.position.x;

    }

    void Update()
    {

        // vector2 ist noch nicht korrekt; muss in richtung von objekt 2 zeigen
        // vector2.right = (1,0)
        if (dirRight)
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        //sobald objekt entfernung erreicht wird flag gesetzt 
        if (transform.position.x >= xMainPosition + distancePosition)
        {
            dirRight = false;
        }

        if (transform.position.x <= xMainPosition - distancePosition)
        {
            dirRight = true;
        }
    }

}
