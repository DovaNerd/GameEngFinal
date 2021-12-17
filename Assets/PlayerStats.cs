using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AI;

public class PlayerStats : MonoBehaviour
{
    private int health = 1000;
    private int armor = 0;

    [DllImport("RandomNum")]
    private static extern int Random();


    void Start()
    {
        armor = Random();
        Debug.Log(armor);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void Damage(int dama)
    {
        health = health - (dama + armor);
    }
}
