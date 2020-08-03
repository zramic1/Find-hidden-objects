using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class pomijeranjeStore : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    private bool _isOutsideTrigger = true;
    public AudioSource audioData;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isInsideTrigger == true)
        {
            anim.SetTrigger("pomjeriStoru");
            audioData.Play();
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
        audioData.Stop();
    }

    void pauseAnimationEvent()
    {

        anim.enabled = false;

    }

}
