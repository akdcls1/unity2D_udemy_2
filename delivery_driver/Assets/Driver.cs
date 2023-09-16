using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // unity 상에서 제어가능 추가 -> SerializeField
    [SerializeField] float steerSpeed = 0.1f;

    [SerializeField] float moveSpeed = 0.01f;

    void Start() // 시작 시에만 적용 시 스타트에 소스 추가
    {
        
    }

    void Update() // 실시간 적용 시 업데이트에 소스 추가
    {
        //Input.getAxis에 Input Manager Axes 값 넣으면 해당 버튼 클릭시 제어가능
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // transform 으로 돌거나(Rotate) 속도(Translate)변경 가능
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
