using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custmer_spawn : MonoBehaviour
{

    public GameObject unit;//�մ� ������
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 10);//���� 3���� Spawn 10���� �������� ����
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(unit, transform.position, Quaternion.identity);//�ν��Ͻ�ȭ 
    }

}
