using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPlacer : MonoBehaviour
{
    static List<Transform> wallList;

    public static void PlaceWall(Vector3 position, Transform capsule)
    {
        Transform newWall = Instantiate(capsule, position, Quaternion.identity);
        wallList.Add(newWall);
    }
}
