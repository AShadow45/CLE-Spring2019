using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio1 : MonoBehaviour
{

    public AudioClip Voice1;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = Voice1;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit2");

            GetComponent<AudioSource>().Play();
            Destroy(GetComponent<SphereCollider>());
        }
    }
}
