using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public GameObject Player;

    public Spawn spawn;

    public Key key;

    public Vector3 point1;

    public Vector3 point2;

    public float speed = 5;

    public Core core;

    public bool kill = false;
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
        if (other.gameObject == Player)
        {
            Player.GetComponent<CharacterController>().enabled = false;

            Player.transform.position = spawn.SpawnPoint;

            Player.GetComponent<CharacterController>().enabled = true;

            key.HasKey = false;

            key.gameObject.SetActive(true);

        }
    }
}
