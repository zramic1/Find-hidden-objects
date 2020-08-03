using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otvaranjeVrata1 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _isInsideTrigger = false;
    private bool _isOutsideTrigger = true;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isInsideTrigger == true)
        {
            anim.SetTrigger("otvoriVrata1");
        }

    }


    void OnTriggerEnter(Collider other)
    {
        _isInsideTrigger = true;

    }

    void OnTriggerExit(Collider other)
    {
        _isInsideTrigger = false;
        anim.enabled = true;
    }

    void pauseAnimationEvent()
    {

        anim.enabled = false;

    }
}
