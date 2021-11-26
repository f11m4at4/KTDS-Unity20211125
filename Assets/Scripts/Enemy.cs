using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ʒ��� ��� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : �̵��ӵ�

// ���� �� ����ȿ���� �����ϰ� �ʹ�.
// �ʿ�Ӽ� : ���߰���
public class Enemy : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;
    // �ʿ�Ӽ� : ���߰���
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �Ʒ��� ��� �̵��ϰ� �ʹ�.
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    // ���� �ٸ� ��ü�� �浹 ���� �� ȣ��
    // -> ���� �װ� ���� �װ�
    private void OnCollisionEnter(Collision other)
    {
        // ���� ����
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
