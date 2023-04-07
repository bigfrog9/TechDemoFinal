using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Vector3 Respawn1;
 
    public Vector3 Respawn2;

    public Vector3 Respawn3;

    public Vector3 SpawnPoint;

    public enum CheckPoints { Check1, Check2 ,Check3};

    public CheckPoints checkPoints= CheckPoints.Check1;

    private void Update()
    {
        if (checkPoints==CheckPoints.Check1)
        {
            SpawnPoint = Respawn1;
        }

        else if (checkPoints == CheckPoints.Check2)
        {
            SpawnPoint = Respawn2;
        }
    }
}
