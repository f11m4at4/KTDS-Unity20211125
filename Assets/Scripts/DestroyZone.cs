using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ٸ� ��ü�� �ε����� �ε��� ��ü ����

public class DestroyZone : MonoBehaviour
{
    // Enter, Stay, Exit
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
