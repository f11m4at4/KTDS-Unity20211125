using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 배경이 스크롤 되도록 하고 싶다.
// 필요속성 : Material, 스크롤 속도

public class BG : MonoBehaviour
{
    // 필요속성 : Material, 스크롤 속도
    Material mat;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // 계속 배경이 스크롤 되도록 하고 싶다.
        // P = P0 + vt (0, 1)
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
