using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Ray rayMousePosition;
    [SerializeField] LayerMask mousePositionRayHit;
    RaycastHit mousePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rayMousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(rayMousePosition, out mousePosition ,float.MaxValue, mousePositionRayHit))
        {
            transform.LookAt(mousePosition.point);
        }
    }
}
