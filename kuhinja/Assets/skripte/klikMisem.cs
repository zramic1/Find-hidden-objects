using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klikMisem : MonoBehaviour
{
    public static bool kliknuto = false;
    bool inTrigger = false;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void Update()
    {
        if(inTrigger == true)
        {
            if (Input.GetMouseButton(0))
            {
                kliknuto = true;
            }
        }
    }


}
