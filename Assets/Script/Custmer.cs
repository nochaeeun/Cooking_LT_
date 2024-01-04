using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Custmer : MonoBehaviour
{

    public Sprite sprite1;
    public Sprite sprite2;

    public Transform exitPos;

    public static float arrivalTime = 10.0f;

    Vector3 targetPos = new Vector3(21, 85);

    public Image Time_bar;

    


    
    // Start is called before the first frame update
    void Awake()
    {
        int randomNumber = Random.Range(0, 2);
        if (randomNumber == 0)
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
       
    }

    // Update is called once per frame
    void Update()

    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 5f);
        //arrivalTime = arrivalTime - Time.deltaTime;

        if (transform.position == targetPos)
        {
            arrivalTime = arrivalTime - Time.deltaTime;
            
        }
        if (arrivalTime <= 0)
        {
            Destroy(gameObject);
            arrivalTime = 10.0f;


        }

        Time_bar.fillAmount = arrivalTime/10;
    }
}
