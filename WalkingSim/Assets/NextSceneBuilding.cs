using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneBuilding : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(ExecuteAfterTime());
        StartCoroutine(ExecuteAfterTime2());

    }

    IEnumerator ExecuteAfterTime2()
    {

        yield return new WaitForSeconds(27f);
        audioSource.Play();
    }


    IEnumerator ExecuteAfterTime()
    {
        
        yield return new WaitForSeconds(27f);
        SceneManager.LoadScene("2BuildingInterior");
    }



} //26
