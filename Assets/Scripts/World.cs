using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : Game
{
    public string weather;
    public bool day;
    public int temperature;

    private void Start()
    {
        weather = "storm";
        day = false;
        temperature = 15;
    }
}
