using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    
    private void FixedUpdate()
    {
        //Vector3 newPosition = Player.transform.position + new Vector3(0,0,-10);
       // newPosition.y = 0.1f;
        //transform.position = newPosition;
        transform.position = Vector2.Lerp(transform.position, Player.position, 0.1f);
    }
    
}
