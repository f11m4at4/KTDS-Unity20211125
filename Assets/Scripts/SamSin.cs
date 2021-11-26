using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간에 한번씩 적을 만들고 싶다.
// 필요속성 : 생성시간, 경과시간, 적공장
public class SamSin : MonoBehaviour
{
    // 필요속성 : 생성시간, 경과시간, 적공장
    public float createTime = 2;
    float currentTime = 0;
    public GameObject enemyFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 일정시간에 한번씩 적을 만들고 싶다.
        // 1. 시간이 흘렀으니까.
        currentTime += Time.deltaTime;
        // 2. 생성시간이 됐으니까
        if (currentTime > createTime)
        {
            currentTime = 0;
            // 3. 적 공장에서 적을 만들어야 한다.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. 적을 배치하고 싶다.
            enemy.transform.position = transform.position;
        }
    }
}
