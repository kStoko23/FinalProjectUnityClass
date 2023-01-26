using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerRocket" || other.gameObject.tag == "EnemyRocket")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("działa");
        }
    }
}
