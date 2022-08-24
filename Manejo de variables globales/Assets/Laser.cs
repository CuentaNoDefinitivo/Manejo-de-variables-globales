using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    Transform puntoInicioLaser;
    Transform puntoFinLaser;
    Ray rayo;
    void Start()
    {
        puntoInicioLaser = transform.GetChild(0);
        puntoFinLaser = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        rayo = new Ray(puntoInicioLaser.position, puntoFinLaser.position - puntoInicioLaser.position);
        if(Physics.Raycast(rayo, out hit, (puntoFinLaser.position - puntoInicioLaser.position).magnitude))
        {
            if (hit.transform.tag == "Player")
            {
                Debug.Log("-hp");
            }
        }
    }
}
