using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custmer_move : MonoBehaviour
{
    Vector3 targetPos = new Vector3(-4, 0);//이동할 위치

    private float arrivalTime = 10.0f;//유지시간
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.05f);//targetPos로 이동

        arrivalTime = arrivalTime - Time.deltaTime;//시간감소

        if (arrivalTime <= 0)//시간초과시 사라짐
        {
            Destroy(gameObject);
        }
    }
}
