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
        if (Input.GetKey(KeyCode.UpArrow) == true) {
            // 위쪽 방향키 입력이 감지된 경우 z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die() {
        // gameObject를 사용해 자신의 게임 오브젝트에 접근, 접근한 게임 오브젝트의 SetActive(false);를 실행하여 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}
