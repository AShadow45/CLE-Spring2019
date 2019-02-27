using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WhiteCountdown : MonoBehaviour
{
    public Image faderImage;

    void Start()
    {
        faderImage.canvasRenderer.SetAlpha(0);
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("3Hospital");


    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") {
            StartCoroutine(ExecuteAfterTime());
            faderImage.CrossFadeAlpha(1, 5, true); //the 5 is time, 1 is transparent
        }
    }
}
