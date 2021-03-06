using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
// 필요속성 : 총알 공장, 총구

public class PlayerFire : MonoBehaviour
{
    // 필요속성 : 총알 공장, 총구
    public GameObject bulletFactory;
    public GameObject firePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
        // 1. 발사버튼을 눌렀으니까
        // -> 만약 사용자가 발사버튼을 눌렀다면
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 총알을 만들어야 한다.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. 총알을 발사하고 싶다.
            bullet.transform.position = firePosition.transform.position;
            // 4. 총구의 방향으로 설정
            bullet.transform.up = firePosition.transform.up;
        }
    }
}
