using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아래로 계속 이동하고 싶다.
// 필요속성 : 이동속도

// 죽을 때 폭발효과를 생성하고 싶다.
// 필요속성 : 폭발공장
public class Enemy : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5;
    // 필요속성 : 폭발공장
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 아래로 계속 이동하고 싶다.
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    // 적이 다른 물체와 충돌 했을 때 호출
    // -> 갸도 죽고 나도 죽고
    private void OnCollisionEnter(Collision other)
    {
        // 폭발 생성
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
