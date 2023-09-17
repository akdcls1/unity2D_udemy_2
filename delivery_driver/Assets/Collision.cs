using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) // 충돌메서드
    { 
        Debug.Log("Shit!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("What was that!!?");
    }
}
