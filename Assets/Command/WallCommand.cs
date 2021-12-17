using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCommand : ICommand
{

    Vector3 position;
    Transform wall;

    public WallCommand(Vector3 position, Transform wall)
    {
        this.position = position;
        this.wall = wall;
    }

    public void Execute()
    {
        WallPlacer.PlaceWall(position, wall);
    }
}
