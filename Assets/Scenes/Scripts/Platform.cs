using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;

public class Platform : MonoBehaviour
{
    new public enum DESTINATION
    {
        DEST1, DEST2
    };

    DESTINATION Destination=DESTINATION.DEST1;

    new public Vector3 Dest1;

    new public Vector3 Dest2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Destination == DESTINATION.DEST1)
        {
            //transform.position = Dest1 * Time.deltaTime;

            transform.Translate(Dest1.normalized * Time.deltaTime*4);

            Debug.Log("Heading to Dest1");


            if (Vector3.Distance(Dest1, transform.position) <= 1)
            {
                Debug.Log("Dest1 reached");

                Destination = DESTINATION.DEST2;
            }
        }

        else if (Destination == DESTINATION.DEST2) {
            //transform.position = Dest2 * Time.deltaTime;

            transform.Translate(Dest2.normalized * Time.deltaTime*4);

            if (Vector3.Distance(Dest2, transform.position) <= 1)
            {
                Destination = DESTINATION.DEST1;
            }
        }
    }

    /*
    void Go1()
    {
        transform.position = Dest1 * Time.deltaTime;

        if (Vector3.Distance(Dest1, transform.position) <= 0.5)
        {
            Destination = DESTINATION.DEST2;
        }
    }

    void Go2()
    {
        transform.position = Dest2 * Time.deltaTime;

        if (Vector3.Distance(Dest2, transform.position)<=0.5)
        {
            Destination = DESTINATION.DEST1;
        }
    }
    */
}
