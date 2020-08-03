using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prikazSlike : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Canvas canvasStart;
    [SerializeField] private Text text;
    [SerializeField] private Text textU;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Canvas meni;
    [SerializeField] private Button button;
    [SerializeField] private Text Timer;
    [SerializeField] private Light light;
    public bool insideTrigger;
    public bool isImageOn;
    public bool isCanvasOn;
    public bool isMeniOn;
    private float startTime;
    private bool finnished;
    float m;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        image.enabled = true;
        canvasStart.enabled = true;
        text.enabled = true;
        isImageOn = true;
        textU.enabled = false;
        canvas.enabled = false;
        isCanvasOn = false;
        button.enabled = false;
        meni.enabled = false;
        insideTrigger = false;
        isMeniOn = false;
        startTime = Time.time;
        light.enabled = false;
        finnished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isImageOn == true && isCanvasOn == false)
        {
            StartCoroutine(ShowAndHide(image, canvasStart, text, 5.0f));
        }
        else if(isImageOn == false && isCanvasOn == true)
        {
            textU.enabled = true;
            canvas.enabled = true;
            StartCoroutine(ShowAndHide2(textU, canvas, 12.0f));
        }

        if (Input.GetKeyDown(KeyCode.M) && insideTrigger == true)
        {
            if(isMeniOn == false)
            {
                meni.enabled = true;
                button.enabled = true;
                isMeniOn = true;
            }
            else
            {
                meni.enabled = false;
                button.enabled = false;
                isMeniOn = false;
            }
            
        }

        if (klikMisem.kliknuto == true)
        {
            finnished = true;
        }

        if (finnished == false)
        {
            float t = Time.time - startTime;
            m = ((int)t / 60);
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f0");
            Timer.text = minutes + ":" + seconds;
        }
        else
        {
            return;
        }
        
        

        if(m == 5 && klikMisem.kliknuto == false)
        {
            light.enabled = true;
        }
        
        
    }

    IEnumerator ShowAndHide( Image go, Canvas i, Text t, float delay)
    {
        yield return new WaitForSeconds(delay);
        go.enabled = false;
        i.enabled = false;
        t.enabled = false;
        isImageOn = false;
        isCanvasOn = true;
    }

    IEnumerator ShowAndHide2(Text t, Canvas c , float delay)
    {
        yield return new WaitForSeconds(delay);
        t.enabled = false;
        c.enabled = false;
        isCanvasOn = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        insideTrigger = true;
    }
}
