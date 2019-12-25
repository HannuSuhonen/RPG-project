using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(HelloWorld());
    }

    IEnumerator HelloWorld()
    {
        Debug.Log("Wow, what is this!?");
        yield return new WaitForSeconds(5f);
        Debug.Log("Hello World!");
    }
}
