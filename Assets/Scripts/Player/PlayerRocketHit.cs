using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerRocketHit : MonoBehaviour
{
    ScoreController scoreController;
    [SerializeField] private GameObject controller;
    public int enemiesDown = 0;
    public int count;
    private GameObject[] enemies;
    private void Awake()
    {
        scoreController = controller.GetComponent<ScoreController>();
    }

    private void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        count = enemies.Length;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="PlayerRocket")
        {
            scoreController.score += 100;
            enemiesDown++;
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("działa");
        }
    }
}
