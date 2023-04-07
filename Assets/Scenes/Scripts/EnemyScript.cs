using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool Gopoint1 = true;

    public bool Gopoint2 = false;

    public Vector3 point1;

    public Vector3 point2;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Gopoint1)
        {
            transform.position = Vector3.MoveTowards(transform.position, point1, Time.deltaTime * speed);
        }

        else if (Gopoint2)
        {
            transform.position = Vector3.MoveTowards(transform.position, point2, Time.deltaTime * speed);
        }

        if (Gopoint1 && Vector3.Distance(transform.position, point1) <= 0.05f)
        {
            Gopoint1 = false;
            Gopoint2 = true;
        }

        else if (Gopoint2 && Vector3.Distance(transform.position, point2) <= 0.05f)
        {
            Gopoint1 = true;
            Gopoint2 = false;
        }

       
    }

    

    
}