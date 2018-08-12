﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [Header("Shop Settings")]
    [Space]
    public int saveRoomPrice = 3;
    public int repairRoomPrice = 10;

    [Header("Room Service")]
    [Space]
    public float saveRoomSpeed = 0.5f;
    public float repairRoomSpeed = 0.2f;

    [HideInInspector]
    public bool isPaused;

    public static GameManagerScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        isPaused = true;
        UIManagerScript.instance.ShowGameOverScreen();
    }
}