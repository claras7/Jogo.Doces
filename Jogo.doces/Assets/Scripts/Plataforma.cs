using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float plataformTime;
    private TargetJoint2D target;
    private BoxCollider2D BoxColl;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        BoxColl = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D (Collision2D collision){
        if(collision.gameObject.tag == "Player")
        {
            Invoke("Falling", plataformTime);
        }
    }
    void Falling()
    {
        target.enabled = false;
        BoxColl.isTrigger = true;
    }
}
