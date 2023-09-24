using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) // 충돌메서드
    { 
        Debug.Log("Shit!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // 패키지 픽업했을경우
        if(other.tag == "Package")
        {
            Debug.Log("Package pick up!");
        }
    }
}
