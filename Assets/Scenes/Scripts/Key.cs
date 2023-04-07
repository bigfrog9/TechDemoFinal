using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool HasKey = false;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (10,0,10)*Time.deltaTime*5);

        if (HasKey==true)
        {
            gameObject.SetActive(false);
        }

        else if (HasKey==false)
        {
            Debug.Log("Key is back!");
            gameObject.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            HasKey = true;
        }
    }
}
