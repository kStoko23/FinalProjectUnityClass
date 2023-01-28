using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyRocketHit : MonoBehaviour
{
    public int playerHealth = 3;
    ScoreController scoreController;
    [SerializeField] private GameObject controller;
    private void Awake()
    {
        scoreController = controller.GetComponent<ScoreController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyRocket")
        {
            Destroy(other.gameObject);
            scoreController.score-=50;
            playerHealth--;
        }
    }
}
