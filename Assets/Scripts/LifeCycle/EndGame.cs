using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class EndGame : MonoBehaviour
{
    public int enemiesDown = 0;
    public int count;
    int enemiesStart = 0;
    GameObject[] enemies;
    [SerializeField] 
    GameObject player;
    EnemyRocketHit enemyRocketHit;
    [SerializeField] 
    GameObject gameWonMenu;
    [SerializeField] 
    GameObject gameLostMenu;
    [SerializeField] 
    AudioSource audioSourceGameOver;
    [SerializeField] 
    AudioSource audioSourceGameWon;
    [SerializeField] 
    AudioSource backgroundMusic;
    GameMenuController gameMenuController;
    [FormerlySerializedAs("timerDisplay")] [SerializeField] 
    TextMeshProUGUI gameLostTimerDisplay;
    [FormerlySerializedAs("scoreDisplay")] [SerializeField] 
    TextMeshProUGUI gameLostScoreDisplay;
    [SerializeField] 
    TextMeshProUGUI gameWonTimerDisplay;
    [SerializeField] 
    TextMeshProUGUI gameWonScoreDisplay;
    private void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyRocketHit = GameObject.Find("PlayersShip").GetComponent<EnemyRocketHit>();
        gameMenuController = GameObject.Find("HUD").GetComponent<GameMenuController>();;
    }

    private void Start()
    {
        enemiesStart=enemies.Length;
    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        count = enemies.Length;
        enemiesDown = enemiesStart - count;
        
        if (enemiesDown == enemiesStart)
        {
            backgroundMusic.Stop();
            audioSourceGameWon.Play();
            gameMenuController.StopTimer();
            
            gameWonTimerDisplay.text = gameMenuController.timerDisplay.text;
            gameWonScoreDisplay.text = gameMenuController.scoreDisplay.text;
            
            DestroyAllObjects();
            ShowGameWonMenu();
        }
        else if(enemyRocketHit.playerHealth==0)
        {
            backgroundMusic.Stop();
            audioSourceGameOver.Play();
            gameMenuController.StopTimer();
            
            gameLostTimerDisplay.text = gameMenuController.timerDisplay.text;
            gameLostScoreDisplay.text = gameMenuController.scoreDisplay.text;
            
            DestroyAllObjects();
            ShowGameLostMenu();
        }
    }

    void ShowGameWonMenu()
    {
        gameWonMenu.SetActive(true);
    }
    void ShowGameLostMenu()
    {
        gameLostMenu.SetActive(true);
    }

    void DestroyAllObjects()
    {
        Destroy(player);
        for (var i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
