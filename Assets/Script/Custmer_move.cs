using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custmer_move : MonoBehaviour
{
    Vector3 targetPos = new Vector3(-4, 0);//�̵��� ��ġ

    private float arrivalTime = 10.0f;//�����ð�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.05f);//targetPos�� �̵�

        arrivalTime = arrivalTime - Time.deltaTime;//�ð�����

        if (arrivalTime <= 0)//�ð��ʰ��� �����
        {
            Destroy(gameObject);
        }
    }
}
