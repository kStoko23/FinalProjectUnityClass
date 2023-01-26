using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRocketHit : MonoBehaviour
{
    public int playerHealth = 3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyRocket")
        {
            Destroy(other.gameObject);
            playerHealth--;
            Debug.Log("działa");
            if(playerHealth == 0)
            {
                Destroy(gameObject);
                Debug.Log("przegrałeś");
            }
        }
        
    }
}
