using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ����� ��ũ�� �ǵ��� �ϰ� �ʹ�.
// �ʿ�Ӽ� : Material, ��ũ�� �ӵ�

public class BG : MonoBehaviour
{
    // �ʿ�Ӽ� : Material, ��ũ�� �ӵ�
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
        // ��� ����� ��ũ�� �ǵ��� �ϰ� �ʹ�.
        // P = P0 + vt (0, 1)
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
