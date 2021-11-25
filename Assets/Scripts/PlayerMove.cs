using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에 따라 상하좌우로 이동하고 싶다.
// 1. 필요속성 : 이동속도
public class PlayerMove : MonoBehaviour
{
    // 1. 필요속성 : 이동속도
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 입력에 따라 상하좌우로 이동하고 싶다.
        // 1. 사용자의 입력에 따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. 방향이 필요.
        Vector3 dir = (Vector3.right * h + Vector3.up * v);
        
        // 3. 이동하고싶다.

        // 물체를 오른쪽으로 계속 이동하게 하고 싶다.
        // P = P0 + vt
        Vector3 p0 = transform.position;
        Vector3 vt = dir * speed * Time.deltaTime;
        Vector3 p = p0 + vt;
        transform.position = p;
        //transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
