using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLifeCycleControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BarierWall")
        {
            Destroy(gameObject);
            Debug.Log("rakieta zniszczona");
        }
    }
}
