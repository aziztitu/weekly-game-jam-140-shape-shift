﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsMenu : MonoBehaviour
{
    public Toggle invertY;

    void OnEnable()
    {
        invertY.isOn = GameManager.Instance.gameData.playerSettings.shouldInvertY;
    }

    public void UpdateInvertY()
    {
        GameManager.Instance.gameData.playerSettings.shouldInvertY = !invertY.isOn;
        
        if (!invertY.isOn)
        {
            print("false");
        }
        else
        {
            print("true");
        }
        SaveSystem.SaveData<GameManager.GameData>(GameManager.Instance.gameData, GameManager.Instance.saveFile);
    }
}
