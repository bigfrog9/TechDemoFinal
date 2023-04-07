using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Key key;
    public GameObject Player;

    public LeftDoor leftDoor;
    public RightDoor rightDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (key.HasKey)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (key.HasKey&&other.gameObject==Player)
        {
            rightDoor.opening = true;
            leftDoor.opening = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        rightDoor.opening = false;
        leftDoor.opening = false;
    }
}
