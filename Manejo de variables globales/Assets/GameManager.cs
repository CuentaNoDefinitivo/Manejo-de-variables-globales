using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager gM;
    private void Awake()
    {
        if (gM != null && gM != this)
        {
            DestroyImmediate(this.gameObject);
        }
        else
        {
            gM = this;
        }
    }
}
