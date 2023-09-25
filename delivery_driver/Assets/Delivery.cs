using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other) // 충돌메서드
    { 
        Debug.Log("Shit!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // 패키지 픽업했을경우
        if(other.tag == "Package")
        {
            Debug.Log("Package pick up!");
            hasPackage = true;
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Deliver!");
            hasPackage = false;
        }
    }
}
