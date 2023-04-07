using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoor : MonoBehaviour
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

            transform.position = Vector3.MoveTowards(transform.position, open, Time.deltaTime * 3);

        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, closed, Time.deltaTime * 2);

        }
        /*
        if (opening)
        {
            if (moving)
            {
                transform.Translate(open.normalized * Time.deltaTime * 2);
            }
            
            if (Vector3.Distance(open, transform.position) <= 1)
            {
                moving = false;
            }
        }

        else
        {
            if (moving)
            {
                transform.Translate(closed.normalized * Time.deltaTime * 2);
            }

            if (Vector3.Distance(closed, transform.position) <= 1)
            {
                moving=false;
            }
        }
        */
    }
}
