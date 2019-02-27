using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") {
            Debug.Log("hit");

            audioSource.Play();
        }
    }
}
