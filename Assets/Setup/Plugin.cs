using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AI;
public class Plugin : MonoBehaviour
{
    [DllImport("RandomNum")]
    private static extern int Random();


    void Start()
    {
        Debug.Log(Random());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
