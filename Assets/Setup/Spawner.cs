using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region singleton
    public static Spawner Instance;
    #endregion

    public GameObject Ball;

    private Queue<GameObject> ballPool = new Queue<GameObject>();

    private int currentnum = 0;

    private void Awake()
    {
        Instance = this;
        GrowPool();
    }
    public GameObject GetFromPool()
    {
        if (ballPool.Count == 0)
            GrowPool();
        var instance = ballPool.Dequeue();
        instance.SetActive(true);
        return instance;
    }
    private void GrowPool()
    {
        for (int i = 0; i < 10; i++)
        {
            var instanceToAdd = Instantiate(Ball);
            instanceToAdd.transform.SetParent(transform);
            AddToPool(instanceToAdd);
        }
    }
    public void AddToPool(GameObject instance)
    {
        instance.SetActive(false);
        ballPool.Enqueue(instance);
    }
}
