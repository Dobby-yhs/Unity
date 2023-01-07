using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    
    
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();   
    }

    // Update() 메서드는 한 프레임에 한 번, 매 프레임마다 반복 실행된다.
    void Update()
    {   
        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // 리지드바디의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity; 
        /* 
        Rigidbody의 AddForce()와 velocity의 차이
            - AddForce() 메서드는 힘을 누적하고 속력을 점진적으로 증가시킨다.
            - velocity는 이전 속도를 지우고 새로운 속도를 사용하여 관성을 무시하고 속도가 즉시 변경된다.
        */

        /* 보완 전 코드
        if (Input.GetKey(KeyCode.'화살표 방향') == true) {
            // 방향키 입력이 감지된 경우 x or z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        */

    }

    public void Die() {
        // gameObject를 사용해 자신의 게임 오브젝트에 접근, 접근한 게임 오브젝트의 SetActive(false);를 실행하여 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        // 씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();
        // 가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        gameManager.EndGame();
    }
}
