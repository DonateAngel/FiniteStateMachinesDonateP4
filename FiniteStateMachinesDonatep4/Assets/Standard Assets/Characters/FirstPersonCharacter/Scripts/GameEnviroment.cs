using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public sealed class GameEniroment 
{
    private static GameEniroment insatnce;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public static GameEniroment Singleton
    {
        get
        {
            if (insatnce == null)
            {
                insatnce = new GameEniroment();
                insatnce.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));

            }
            return insatnce;
        }
    }
}
