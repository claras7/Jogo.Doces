using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolim : MonoBehaviour
{
    private Animator animT;
    public float forcaDaMola;
    void Awake()
    {
        animT = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("player"))
        {
            animT.Play("trampolim.mola");
            collider.gameObject.GetComponent<Player>().BoostPlayer(forcaDaMola);
        }
    }
    
}
