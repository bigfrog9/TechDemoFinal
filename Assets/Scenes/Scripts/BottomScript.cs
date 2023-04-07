using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScript : MonoBehaviour
{
    public GameObject Player;

    public Spawn spawn;

    public Key key;

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
