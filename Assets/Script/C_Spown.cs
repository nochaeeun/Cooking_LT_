using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Spown : MonoBehaviour
{
    public GameObject Custmers;
    public GameObject Menu;
    public Transform StartPos;
    public Transform MenuPos;

    
    


    void Start()
    {
       

        InvokeRepeating("CreateCustmer", 0f, 13f);
        
        InvokeRepeating("CreateMenu", 1f, 13f);
        

    }
    // Update is called once per frame
    void Update()
    {
        

    
        

        
    }

    public void CreateCustmer() 
    {
        GameObject CustmerClone = Instantiate(Custmers, transform.position,Quaternion.identity);
        
    }

    public void CreateMenu() 
    {
        GameObject MenuClone = Instantiate(Menu, MenuPos.position, Quaternion.identity);
    }
}
