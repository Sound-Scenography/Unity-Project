using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class circle : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    public int degree;
    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, degree * Time.deltaTime);
    }
}
