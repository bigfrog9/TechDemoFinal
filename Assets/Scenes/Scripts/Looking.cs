using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Looking : MonoBehaviour
{

    public int ammo;

    public GameObject win;

    public GameObject WinText;

    public GameObject InteractText;

    public GameObject flash;

    public TextMeshProUGUI ammoCount;

    public AudioSource winclip;

    public AudioSource gunShot;

    public RaycastHit kill;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, win.transform.position) <= 3)
        {
           InteractText.SetActive(true);

        }

        else
        {
            InteractText.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(transform.position,win.transform.position)<=3)
        {
            Debug.Log("WIN!!");
            WinText.SetActive(true);

            winclip.Play();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && ammo > 0)
        {
            flash.SetActive(true);
            gunShot.Play();

            ammo = ammo - 1;

            if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out kill,30f))
            {
                if (kill.collider.gameObject.tag == "Killable")
                {
                    kill.collider.gameObject.SetActive(false);
                    Debug.Log("Dead");
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            flash.SetActive(false);
        }

        ammoCount.text = "Ammo: " + ammo.ToString();
    }

}
