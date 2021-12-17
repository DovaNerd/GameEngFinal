using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCommand : ICommand
{

    private Vector3 position;
    private Transform Wall;

    public WallCommand(Vector3 position, Transform wall)
    {
        this.position = position;
        this.Wall = wall;
    }

    public void Execute()
    {
        WallPlacer.PlaceWall(position, Wall);
    }
}
