using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceKeyCommand : ICommand
{
    
    Vector3 position;
    Transform Key;

    public PlaceKeyCommand(Vector3 position, Transform Key)
    {
        this.position = position;
        this.Key = Key;
    }

    public void Execute()
    {
        KeyPlacer.PlaceKey(position, Key);
    }

    public void Undo()
    {
        KeyPlacer.RemoveKey(position);

        
    }
}

