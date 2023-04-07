using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor : MonoBehaviour
{
    public bool opening = false;

    public Vector3 closed;

    public Vector3 open;

    public bool moving;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            
            transform.position=Vector3.MoveTowards(transform.position, open, Time.deltaTime*3);
            
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, closed, Time.deltaTime * 2);

        }

    }

}
