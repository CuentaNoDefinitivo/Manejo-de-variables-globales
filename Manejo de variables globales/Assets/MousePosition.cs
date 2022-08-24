using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    Ray rayMousePosition;
    [SerializeField] LayerMask mousePositionRayHit;
    RaycastHit mousePosition;
    void Update()
    {
        rayMousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}
