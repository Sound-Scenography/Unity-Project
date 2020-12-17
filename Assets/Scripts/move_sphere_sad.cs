using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_sphere_sad : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    private float xMainPosition = 0.0f;
    public float distancePosition = 5.0f;


    void Start()
    {
        xMainPosition = transform.position.x;

    }

    void Update()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

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