using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData
{
    public int engine;
    public int liftKit;
    public int wheel;
    public int traction;
    public GameObject[] cars = new GameObject[10];

    public PlayerData(Player player) 
    {
        engine = player.engine;
        liftKit = player.liftKit;
        wheel = player.wheel;
        traction = player.traction;
        cars = player.cars;
    }
    void Awake() {
        cars[0] = GameObject.Find("CAR");
    }
}
