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
        if(collider.gameObject.CompareTag("Player"))
        {
            animT.SetTrigger("JumpTrampolim");

            collider.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collider.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcaDaMola, ForceMode2D.Impulse);
        }
    }
    
}
