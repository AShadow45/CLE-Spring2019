using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light[] roomLights;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            for (int i = 0; i < roomLights.Length; i++) {
                StartCoroutine(Flicker(roomLights[i]));
            }
        } 
    }

    IEnumerator Flicker (Light rl)
    {
        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;
        yield return new WaitForSeconds(.1f);
        rl.intensity = 1;
        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;
        yield return new WaitForSeconds(.1f);
        rl.intensity = 1;
        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;
        yield return new WaitForSeconds(.1f);
        rl.intensity = 1;
        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;
        
    }
}
