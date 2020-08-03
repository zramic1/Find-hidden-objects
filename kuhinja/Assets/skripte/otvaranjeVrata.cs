using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otvaranjeVrata : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    private bool _isOutsideTrigger = true;
    public Collider Collider;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Collider.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && _isInsideTrigger == true)
        {
            anim.SetTrigger("otvoriVrata");
            Collider.enabled = true;
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
