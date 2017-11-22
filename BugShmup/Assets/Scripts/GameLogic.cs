﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    //public GameObject Player;
    public static PlayerController player;
    public int score;

    //Boundary variables
    BoxCollider bulletKill;
    [SerializeField] GameObject BG;
    [SerializeField] float boxHeight;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        score = 0;
        Debug.Log(Camera.main);
        CreateBoundaries();
        //BG = GameObject.FindGameObjectWithTag("BG");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SaveCurrentScore(score);
            SceneManager.LoadScene("PrototypeLeaderboard");
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
    }

    private void SaveCurrentScore(int value)
    {
        //Save current score to PlayerPrefs so it can be used in another scene
        PlayerPrefs.SetInt("currentScore", value);
    }

    void CreateBoundaries()
    {
        bulletKill = new BoxCollider();
        bulletKill.center = BG.transform.position;
        float Ydist = Vector3.Distance(BG.transform.position, Camera.main.transform.position);
        float frustumHeight = 2.0f * Ydist * Mathf.Tan(Camera.main.fieldOfView * 0.5f * Mathf.Deg2Rad);
        float frustumWidth = frustumHeight * Camera.main.aspect;

        bulletKill.size.Set(frustumWidth, boxHeight, frustumHeight);
    }
}
