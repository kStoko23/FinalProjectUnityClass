using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    Slider Healthbar;
    //update healtbar fill level accordingy to player health
    //player health is stored in EnemyRockerHit script 
    //which is attached to the player gameObject
    void Update()
    {
        Healthbar.value = Player.GetComponent<EnemyRocketHit>().playerHealth;
    }
}
