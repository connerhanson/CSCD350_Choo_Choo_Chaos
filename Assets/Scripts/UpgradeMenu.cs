using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class UpgradeMenu : MonoBehaviour
{
    public TMP_Text EngineText;
    public TMP_Text LiftKitText;
    public TMP_Text WheelsText;
    public TMP_Text TractionText;

    private int engine = 0;

    private int lift = 0;
    private int wheel = 0;
    private int traction = 0;
    public GameManager gameManager;
    public PlayerData playerData;

    void Start() 
    { 
        gameManager = FindObjectOfType<GameManager>();
        playerData = gameManager.playerData;
    }

    public void Update()
    {
        
        EngineText.text = engine + "/10";
        LiftKitText.text = lift + "/10";
        WheelsText.text = wheel + "/10";
        TractionText.text = traction + "/10";
        
    }

    public void UpgradeEngine ()
    {
        engine += 1;
        playerData.cars[0].GetComponent<drive>()._speed += 10;
        Debug.Log(playerData.cars[0].GetComponent<drive>()._speed);

    }

    public void UpgradeLiftKit ()
    {
        lift += 1;

    }

    public void UpgradeWheels()
    {
        wheel += 1;

    }

    public void UpgradeTraction ()
    {
        traction += 1;
        playerData.cars[0].GetComponent<drive>()._rotationSpeed += 10;

    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
