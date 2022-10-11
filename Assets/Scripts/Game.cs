using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game game;

    public Player player { get { return GameObject.FindObjectOfType<Player>(); } }
    public World world { get { return GameObject.FindObjectOfType<World>(); } }
    public Data data { get { return GameObject.FindObjectOfType<Data>(); } }

    private void Awake()
    {
        game = this;

        // Make the game run as fast as possible
        Application.targetFrameRate = 300;
    }
}
