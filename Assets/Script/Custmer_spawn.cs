using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custmer_spawn : MonoBehaviour
{

    public GameObject unit;//손님 프리팹
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 10);//시작 3초후 Spawn 10초의 간격으로 생성
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(unit, transform.position, Quaternion.identity);//인스턴스화 
    }

}
