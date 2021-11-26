using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 다른 물체와 부딪히면 부딪힌 물체 제거

public class DestroyZone : MonoBehaviour
{
    // Enter, Stay, Exit
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
