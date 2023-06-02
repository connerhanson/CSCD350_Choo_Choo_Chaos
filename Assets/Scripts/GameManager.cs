using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Player player;
    public PlayerData playerData;

    public static GameManager instance;
    private void Start()
    {

        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }

        if (SaveSystem.LoadPlayer() == null) 
        {
            playerData = new PlayerData(player);
        } else 
        {
            playerData = SaveSystem.LoadPlayer();
            player.cars = playerData.cars;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnApplicationQuit()
    {
        SaveSystem.SavePlayer(player);
    }
}
