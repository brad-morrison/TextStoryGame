using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Game
{
    public int health;
    public int hunger;
    public int wood;
    public int temperature;

    private void Start()
    {
        health = 100;
        hunger = 100;
        wood = 0;
        temperature = 30;
    }
}
