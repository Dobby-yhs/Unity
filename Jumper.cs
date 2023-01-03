using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // 변수 myRigidbody에 Cube 게임 오브젝트의 Rigidbody 컴포넌트를 할당하지 않으면 myRigidbody는 어떠한 실체도 가리키고 있지 않아 에러가 발생하게 된다.

    void Start() {
        myRigidbody.AddForce(0, 500, 0);
    }
}
