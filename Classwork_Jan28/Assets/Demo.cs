using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public Text outPut;
    public GameObject prefab;
    public int[] numbers;
    
    void Start()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("cube");
        foreach (GameObject cube in cubes) {
            Destroy(cube);
        }
        //for (int i = 0; i < cubes.Length; i++) {
        //    Destroy(cubes[i]);
        //}
        //StartCoroutine(MakeBlocks());
        //for (int i = 0; i < numbers.Length; i++)
        //{
         //   outPut.text = numbers[i].ToString() + "\n";
       // }
    }

   // IEnumerator MakeBlocks() {
   //     for (int i = 0; i < 20; i++)
    //    {
    //        for (int j = 0; j < 20; j++) { 
    //            Vector3 pos = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    //            Instantiate(prefab, pos, Quaternion.identity);
    //        }
    //        yield return null;

    //    }
   // }

    
    void Update()
    {
        
    }
}
