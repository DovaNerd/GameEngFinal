using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Spawner.Instance.AddToPool(gameObject);
    }

    private void Awake()
    {
        RAMMING();
    }

    int[] data;

    private void RAMMING()
    {
        data = new int[1000];
        for(int i=0; i<1000; i++)
        {
            data[i] = i;
        }
    }
}
