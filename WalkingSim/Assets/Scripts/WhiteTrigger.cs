using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteTrigger : MonoBehaviour
{
    public Image faderImage;


    // Start is called before the first frame update
    void Start()
    {
        faderImage.canvasRenderer.SetAlpha(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        faderImage.CrossFadeAlpha(1,5,true); //the 5 is time, 1 is transparent
    }
}
