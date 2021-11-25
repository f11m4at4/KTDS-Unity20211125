using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �����¿�� �̵��ϰ� �ʹ�.
// 1. �ʿ�Ӽ� : �̵��ӵ�
public class PlayerMove : MonoBehaviour
{
    // 1. �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ������� �Է¿� ���� �����¿�� �̵��ϰ� �ʹ�.
        // 1. ������� �Է¿� ����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. ������ �ʿ�.
        Vector3 dir = (Vector3.right * h + Vector3.up * v);
        
        // 3. �̵��ϰ�ʹ�.

        // ��ü�� ���������� ��� �̵��ϰ� �ϰ� �ʹ�.
        // P = P0 + vt
        Vector3 p0 = transform.position;
        Vector3 vt = dir * speed * Time.deltaTime;
        Vector3 p = p0 + vt;
        transform.position = p;
        //transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
