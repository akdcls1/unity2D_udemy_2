using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 이 카메라 포지션 == 자동차 위치 포지션
    
    [SerializeField] GameObject thingToFollow;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
