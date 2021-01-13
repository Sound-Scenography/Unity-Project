using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance_spheres : MonoBehaviour
{

    public GameObject Object1;
    public GameObject Object2;
    public float Distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Object1.transform.position, Object2.transform.position);  
    }

    void OnGUI()
    {
        var distance_string = Distance.ToString();
        GUI.Label(new Rect(0, 0, 140, 40), "Distance Happy - Sad");
        GUI.Label(new Rect(0, 20, 80, 20), distance_string);
    }

}
