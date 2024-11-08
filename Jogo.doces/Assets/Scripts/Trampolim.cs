using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolim : MonoBehaviour
{
    public float forcaDaMola;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("player")){
            collider.gameObject.GetComponent<Player>().BoostPlayer(forcaDaMola);
        }
    }
    
}
