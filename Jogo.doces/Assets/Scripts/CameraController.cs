using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    
    private void FixedUpdate()
    {
        
        transform.position = Vector2.Lerp(transform.position, Player.position, 0.1f);
    }
    
}
