using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRocketHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerRocket")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("działa");
        }
    }
}
