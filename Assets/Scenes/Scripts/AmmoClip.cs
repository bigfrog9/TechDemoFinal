using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoClip : MonoBehaviour
{

    public GameObject Player;

    public Looking looking;

    public int amount = 3;

    public AudioSource reload;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 0, 10) * Time.deltaTime * 8);

        if (looking.ammo <= 0)
        {
            gameObject.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            looking.ammo = looking.ammo + amount;

            reload.Play();

            gameObject.SetActive(false);
        }
    }
}
