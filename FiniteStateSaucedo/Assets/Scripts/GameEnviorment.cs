using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public sealed class GameEnviorment 
{
    private static GameEnviorment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }
    public static GameEnviorment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnviorment();
                instance.Checkpoints.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint"));

            }
            return instance;
        }
    }
}
