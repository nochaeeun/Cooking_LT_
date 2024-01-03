using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random_Menu : MonoBehaviour
{
    public Sprite Coffee;
    public Sprite Bread;
    public Sprite IceCream;
    public Sprite Puding;

    public float aTIme;
   // bool arr;

    
    void Awake()
    {
       // arr = Custmer.arrive;

        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Coffee;
        }
        else if (randomNumber == 1) 
        {
            GetComponent<SpriteRenderer>().sprite = Bread;
        }
        else if (randomNumber == 2) 
        {
            GetComponent<SpriteRenderer>().sprite = IceCream;

        }
        else 
        {
            GetComponent<SpriteRenderer>().sprite = Puding;

        }
    }

    // Update is called once per frame
    void Update()
    {

        aTIme = Custmer.arrivalTime;
        if (aTIme <= 0.5f) 
        {
            Destroy(gameObject);
        }
        Debug.Log(aTIme);
    }
}
