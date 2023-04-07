using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Spawn spawn;

    public GameObject Player;

    public Vector3 Destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==Player)
        {
            Player.GetComponent<CharacterController>().enabled = false;

            Debug.Log("Teleported!");
            Player.transform.position=Destination;

            spawn.checkPoints = Spawn.CheckPoints.Check2;

            Player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
