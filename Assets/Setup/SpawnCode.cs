using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCode : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GameObject ball =  Spawner.Instance.GetFromPool();
            ball.transform.position = this.transform.position;
        }
    }
}
