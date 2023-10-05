using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) // 충돌메서드
    { 
        Debug.Log("Shit!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // 패키지 픽업했을경우
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package pick up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Deliver!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
